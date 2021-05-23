namespace A.Domian.Services
{
    public interface IProductCategoryValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
    }
}
