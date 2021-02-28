using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //newlememek için static yaptık
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountCategoryError = "Bir kategoride en fazla 10 ürün olmalıdır";
        public static string ProductUpdated="Ürün Güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "";
        public static string UserNotFound = "";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "";
    }
}
