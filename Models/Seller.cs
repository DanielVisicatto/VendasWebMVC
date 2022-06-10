namespace VendasWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Método adicionar vendas
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        //Método remover vendas
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        //Total de vendas
        public double TotalSales(DateTime initial, DateTime final)
        {
            // essa operação vai me retornal o total de vendas desse vendedor, neste período
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
