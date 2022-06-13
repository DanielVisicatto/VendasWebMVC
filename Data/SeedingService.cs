using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Data
{
    public class SeedingService
    {
        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        //operação responsável por popular nossa BD
        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRscord.Any())
            {
                return;//o BD já foi populado
            }

            //Departamentos
            Department d1 = new(1, "Computers");
            Department d2 = new(2, "Eletronics");
            Department d3 = new(3, "Fashion");
            Department d4 = new(4, "Books");

            //Vendedores
            Seller s1 = new(1, "Lucas Amancio", "lucaamanc@gmail.com", new DateTime(1993, 6, 21), 4800.0, d1);
            Seller s2 = new(1, "Leandro Silva", "lesilva@gmail.com", new DateTime(1989, 7, 13), 3300.0, d1);
            Seller s3 = new(1, "Paula Visicatto", "pauladuci29@gmail.com", new DateTime(1985, 8, 9), 7950.0, d1);
            Seller s4 = new(1, "Wallace Sinatra", "visicatto@gmail.com", new DateTime(2000, 3, 16), 2800.0, d1);
            Seller s5 = new(1, "Gabriel V. Soares", "visicatto@gmail.com", new DateTime(2002, 11, 29), 2800.0, d1);
            Seller s6 = new(1, "Guilherme Thomazini", "bobb@gmail.com", new DateTime(1997,64, 05), 2200.0, d1);

            //Reg. de venda
            SalesRecord r1 = new(1, new DateTime(2022, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r2 = new(1, new DateTime(2022, 09, 4), 7000.0, SaleStatus.Billed, s6);
            SalesRecord r3 = new(1, new DateTime(2022, 09, 13), 4000.0, SaleStatus.Billed, s5);
            SalesRecord r4 = new(1, new DateTime(2022, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new(1, new DateTime(2022, 09, 21), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new(1, new DateTime(2022, 09, 15), 2000.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new(1, new DateTime(2022, 09, 28), 13000.0, SaleStatus.Billed, s4);
            SalesRecord r8 = new(1, new DateTime(2022, 09, 28), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r9 = new(1, new DateTime(2022, 09, 11), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r10= new(1, new DateTime(2022, 09, 14), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r11= new(1, new DateTime(2022, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r12= new(1, new DateTime(2022, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r13= new(1, new DateTime(2022, 09, 25), 7000.0, SaleStatus.Billed, s4);
            SalesRecord r14= new(1, new DateTime(2022, 09, 29), 10000.0, SaleStatus.Billed, s3);
            SalesRecord r15= new(1, new DateTime(2022, 09, 04), 13000.0, SaleStatus.Billed, s6);
            SalesRecord r16= new(1, new DateTime(2022, 09, 12), 14000.0, SaleStatus.Billed, s1);
            SalesRecord r17= new(1, new DateTime(2022, 09, 5), 3000.0, SaleStatus.Billed, s4);
            SalesRecord r18= new(1, new DateTime(2022, 09, 1), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r19= new(1, new DateTime(2022, 09, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r20= new(1, new DateTime(2022, 09, 22), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r21= new(1, new DateTime(2022, 09, 15), 9000.0, SaleStatus.Billed, s5);
            SalesRecord r22= new(1, new DateTime(2022, 09, 17), 4000.0, SaleStatus.Billed, s6);
            SalesRecord r23= new(1, new DateTime(2022, 09, 24), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r24= new(1, new DateTime(2022, 09, 19), 8000.0, SaleStatus.Billed, s3);
            SalesRecord r25= new(1, new DateTime(2022, 09, 12), 7000.0, SaleStatus.Billed, s4);
            SalesRecord r26= new(1, new DateTime(2022, 09, 31), 5000.0, SaleStatus.Billed, s1);
            SalesRecord r27= new(1, new DateTime(2022, 09, 6), 9000.0, SaleStatus.Billed, s5);
            SalesRecord r28= new(1, new DateTime(2022, 09, 7), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r29= new(1, new DateTime(2022, 09, 23), 12000.0, SaleStatus.Billed, s3);
            SalesRecord r30= new(1, new DateTime(2022, 09, 12), 5000.0, SaleStatus.Billed, s5);

            //Adicioanando esses objetos no banco de dados
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRscord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15,
                r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            //efetivando as alterações
            _context.SaveChanges();
        }
    }
}
