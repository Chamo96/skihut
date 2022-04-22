using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithFiltersForCountSpecifications : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecifications(productSpecParams productParams)
        : base(x => 
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
                (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId) &&
                (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId)
            )
        {
        }
    }
}