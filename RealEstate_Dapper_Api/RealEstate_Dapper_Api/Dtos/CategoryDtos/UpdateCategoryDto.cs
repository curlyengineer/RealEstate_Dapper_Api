namespace RealEstate_Dapper_Api.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }  // veritabanında bit olarak tutulan verilen VS de bool olarak tutulur 
    }
}
