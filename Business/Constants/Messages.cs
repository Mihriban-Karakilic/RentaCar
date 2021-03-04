namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDailyPriceInvalid = "Araç kiralama bedeli 0 dan büyük olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string BrandNotAdded = "Marka ismi 2 karakterden büyük olmalıdır ";
        public static string UserNotAdded = "Tüm alanları doldurunuz";
        public static string RentalsError = "Araç teslimatı yapılmalıdır";
        public static string RentalsAdded = "Kiralama işlemi gerçekleştirildi";


        public static string Added = "Ekleme işlemi başarılı";
        public static string NotAdded = "Ekleme işlemi başarısız";
        public static string Deleted = "Silme işlemi gerçekleştirildi";
        public static string NotDeleted = "Silme işlemi başarısız";
        public static string Update = "Bilgiler güncellendi";
        public static string NotUpdate = "Güncelleme işlemi başarısız";
        public static string Listed = "Bilgiler listelendi";
        public static string NotListed = "Listeleme işlemi başarısız";
        public static string ImageLimitExceeded = "Bir araç için 5 den fazla resim eklenemez";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı ";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string CarImageAdded = "Resim eklendi";
        public static string CarImageDeleted = "Resim Silindi.";
        public static string CarImageUpdated = "Resim Güncellendi.";
        public static string CarImageCountOfCarError = "Bir arabaya 5 den fazla fotoğraf yüklenemez.";
        public static string DefaultCarImageNotFound = "Resim Yok";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string FailedRental = "The car has not yet been delivered";
        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
        public static string NoCarImages = "The car does NOT have any images";


    }
}