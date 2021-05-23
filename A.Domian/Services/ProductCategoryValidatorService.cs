using A.Domian.Exceptions;
using A.Domian.ProductCategorys;

namespace A.Domian.Services
{
    public class ProductCategoryValidatorService : IProductCategoryValidatorService
    {
        private readonly IProductCategoryRepository productCategoryRepository;

        public ProductCategoryValidatorService(IProductCategoryRepository productCategoryRepository)
        {
            this.productCategoryRepository = productCategoryRepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (productCategoryRepository.Exist(title))
                throw new DuplicatedRecordException("همچین محصولی با این نام وجود دارد");
        }
    }
}
