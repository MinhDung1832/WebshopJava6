using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT_POLY_CHSARP5.Data.EF;
using FPT_POLY_CHSARP5.Data.EF.Entities;
using FPT_POLY_CHSARP5.WebApp.Application.Dtos;
using FPT_POLY_CHSARP5.WebApp.Application.Products.Dtos;

namespace FPT_POLY_CHSARP5.WebApp.Application.Products
{
    public class ManageProductService: IManageProductService
    {
        //readonly chỉ đọc ra
        private readonly DBContextFPOLY _Context;
        public ManageProductService(DBContextFPOLY contextFpoly)
        {
            _Context = contextFpoly;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new FProduct()
            {
                Price = request.Price,
            };
            _Context.FProducts.Add(product);
         return  await _Context.SaveChangesAsync();
        }

        public Task<int> Update(ProducUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<ProductViewModel>> getAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
