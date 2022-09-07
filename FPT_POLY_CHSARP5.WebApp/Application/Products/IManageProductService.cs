using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT_POLY_CHSARP5.WebApp.Application.Dtos;
using FPT_POLY_CHSARP5.WebApp.Application.Products.Dtos;

namespace FPT_POLY_CHSARP5.WebApp.Application.Products
{
    //Chức năng cho quản lý admin
   public interface IManageProductService
   {
       Task<int> Create(ProductCreateRequest request);
       Task<int> Update(ProducUpdateRequest request);
       Task<int> Delete(int productId);
       Task<List<ProductViewModel>> getAll();
       Task<PageViewModel<ProductViewModel>> getAllPaging(string keyword,int pageIndex,int pageSize);

    }

   
}
