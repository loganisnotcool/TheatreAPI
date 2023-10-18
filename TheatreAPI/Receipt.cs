namespace TheatreAPI
{
    public class Receipt
    {
        public int Id { get; set; }
        public int AdmissionId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double TotalAmount { get; set; }
    }
}
