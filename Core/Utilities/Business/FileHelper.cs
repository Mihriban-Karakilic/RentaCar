﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.Business
{
    public class FileHelper
	{
		public static string Add(IFormFile file)
		{
			var sourcepath = Path.GetTempFileName();
			if (file.Length > 0)
			{
				using (var stream = new FileStream(sourcepath, FileMode.Create))
				{
					file.CopyTo(stream);
				}
			}
			var result = newPath(file);
			File.Move(sourcepath, result);
			return result;
		}
		public static IResult Delete(string path)
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception exception)
			{
				return new ErrorResult(exception.Message);
			}
			return new SuccessResult();
		}
		public static string Update(string sourcePath, IFormFile file)
		{
			var result = newPath(file);
			if (sourcePath.Length > 0)
			{
				using (var stream = new FileStream(result, FileMode.Create))
				{
					file.CopyTo(stream);
				}
			}
			File.Delete(sourcePath);
			return result;
		}

		public static string newPath(IFormFile file)
		{
			FileInfo Info = new FileInfo(file.FileName);
			string fileExtension = Info.Extension;
			string path = Environment.CurrentDirectory + @"\Images";
			var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + fileExtension;
			var result = $@"{path}\{newPath}";
			return result;
		}
	}
}
