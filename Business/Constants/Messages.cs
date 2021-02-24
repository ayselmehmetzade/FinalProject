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
    }
}
