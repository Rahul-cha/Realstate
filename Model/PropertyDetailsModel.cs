using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Realstate.Model
{
    public class PropertyDetailsModel
    {
        public string? Type { get; set; }
        public string? District { get; set; }

        public string? Province { get; set; }

        public double? Price { get; set; }

        public string? Status { get; set; }

        public int? PostalCode { get; set; }

        [NotMapped]
        public IFormFile? Photos { get; set; }
        public string? Description { get; set; }


        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        public int? PhoneNo { get; set; }
    }
}
