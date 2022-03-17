#pragma checksum "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734e30971d7cc3c72149c3d0ea2925ad3ae97bfd"
// <auto-generated/>
#pragma warning disable 1591
namespace LmazonBookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/_Imports.razor"
using LmazonBookStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<form>
    <div class=""input-group md-form form-sm form-2 pl-0"">

        <input class=""form-control my-0 py-1 red-border"" type=""text"" placeholder=""Search"">

        <div class=""input-group-append"">

            <span class=""input-group-text red lighten-3"" id=""basic-text1"">
                    <i class=""fas fa-search text-grey"" aria-hidden=""true""></i>
            </span>

        </div>
    </div>
</form>
<br>
");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-striped table-bordered table-hover");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.AddMarkupContent(4, "<thead>\n        <tr>\n            <th>Book ID</th>\n            <th>Book Name</th>\n            <th>Author</th>\n            <th>Price</th>\n            <td></td>\n        </tr>\n    </thead>\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 32 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
         if (books?.Count() > 0)
        {
            //List the Books
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
             foreach(LmazonBookStore.Models.Books b in books)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 38 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                         b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 39 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 40 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                         b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 41 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                         b.Price.ToString("$#,##0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 43 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, " Details ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 46 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, " Edit ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
                                                                          x => RemoveProduct(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 52 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Products</td>\n            </tr>\n");
#nullable restore
#line 59 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "href", "/admin/books/create");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/yuze/Downloads/Mission 11 Assignment/LmazonBookStore/Pages/Admin/Books.razor"
       
    public IBookStoreRepository repo => Service;

    public IEnumerable<LmazonBookStore.Models.Books> books { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        books = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";

    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveProduct (LmazonBookStore.Models.Books b)
    {
        repo.DeleteProduct(b);
        await UpdateData();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
