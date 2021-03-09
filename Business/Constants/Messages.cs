using System;
using System.Runtime.Serialization;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarDescriptionInvalid = "Araç açıklaması geçersiz";
        public static string CarDailyPriceInvalid = "Araç günlük ücreti geçersiz";
        public static string CarAddedSuccessfully = "Araç başarıyla eklendi";
        public static string CarsListed = "Araçlar başarıyla listelendi";
        public static string UsersListed = "Kullanıcılar başarıyla listelendi";
        public static string UserInvalid = "Kullanıcı geçersiz";
        public static string UserAddedSuccessfully = "Kullanıcı başarıyla eklendi";
        public static string CarImageLimitExceded = "Bu araca daha fazla fotoğraf ekleyemezsiniz";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string LoginSuccess = "Giriş Başarılı";
        public static string UserAlreadyExist = "Kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenGenerated = "Access token oluşturuldu";
        public static string AuthorizationDenied = "Yetkisiz erişim";
    }
}
