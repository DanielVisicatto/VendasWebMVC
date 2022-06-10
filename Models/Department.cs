using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWebMvc.Models
{
    [Table("Departamento")]
    public class Department
    {
        
        public int Id { get; set; }        
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //Adicionar um vendedor
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Calcular total de vendas do departamento no intervalo de datas
        public double TotalSales(DateTime initial, DateTime final)
        {
            //pega cada vendedor na lista, chama o total de cada e soma no período
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
