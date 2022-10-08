namespace Belgetir.Models.Responses
{
    public record StoreResponse(int id, string base64Pdf, string name, DateTime? Created);
}
