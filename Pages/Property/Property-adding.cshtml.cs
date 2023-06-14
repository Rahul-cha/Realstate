using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Realstate.Model;

namespace Realstate.Pages.Property
{



    public class Property_addingModel : PageModel
    {
        [BindProperty]
        public PropertyDetailsModel PropAdd { get; set; }

        public void OnGet()
        {
        }


        public void OnPost(PropertyDetailsModel Prop)
        {
            if(ModelState.IsValid)
            {
                Prop.PostalCode = PropAdd.PostalCode;
                Prop.PhoneNo = PropAdd.PhoneNo;
                Prop.Photos = PropAdd.Photos;
                Prop.Status = PropAdd.Status;
                Prop.Province = PropAdd.Province;
                Prop.District = PropAdd.District;
                Prop.Description= PropAdd.Description;

            }
        }

    }
}
