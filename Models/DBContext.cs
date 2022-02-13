using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestSupermarket.Models
{

public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        public DBContext(DbContextOptions<DBContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
            if (!Products.Any())
            {
                Products.Add(new Product
                {
                    Name = "Alpen Gold молочная",
                    Price = 90,
                    Weight = 85,
                    Description = "Шоколад Alpen Gold присутствует на российском рынке c 1992 года и его история – это история успеха. Alpen Gold - оптимизм в твоих руках!",
                    Photo = "../my_images/alpenGold.png",
                    IsDiscount = true,
                    NewPrice = 50
                });
                Products.Add(new Product
                {
                    Name = "Княгининское молоко",
                    Price = 42,
                    Weight = 500,
                    Description = "Молочные продукты с пониженной жирностью в нашей стране по праву заняли достойное, престижное место.",
                    IsDiscount = false,
                    Photo = "../my_images/moloko.png"
                });
                Products.Add(new Product
                {
                    Name = "Pepsi Max",
                    Price = 150,
                    Weight = 1500,
                    Description = "Напиток Пепси Макс 1,5л - диетическая версия известного на весь мир безалкогольного прохладительного напитка без сахара и калорий (всего 1,2 ккал на 100г). Максимально насыщенный вкус колы без сахара. Освежающий. Для отличного настроения и бодрости весь день. Без калорий. Пепси Кола - легендарный напиток, изобретенный фармацевтом К. Бредхемом в 1893 году. Pepsi завоевал популярность по всему миру.",
                    IsDiscount = true,
                    Photo = "../my_images/pepsi.png",
                    NewPrice = 75
                });
                Products.Add(new Product
                {
                    Name = "Коньяк Старейшина КВ 40%",
                    Price = 1200,
                    Weight = 500,
                    Description = "Выдержка — 7 лет. Изготовлен из испанских коньячных спиртов региона Кастилья Ла Манча, Испания. Выдержан в бочках из 100-летнего лимузенского дуба в погребах завода ALVISA, Испания. Чрезмерное употребление алкоголя вредит вашему здоровью.",
                    IsDiscount = false,
                    Photo = "../my_images/konina.png"
                });
                Products.Add(new Product
                {
                    Name = "Горошек Bonduelle",
                    Price = 77,
                    Weight = 200,
                    Description = "Нежнейший и сладкий зеленый горошек непревзойденного качества тщательно отбирается, прежде чем попасть в банку. Только у Bonduelle процесс от сбора с грядки до упаковки проходит всего за 4 часа - поэтому на вашем столе всегда самый лучший горошек мозговых сортов, в котором содержится меньше крахмала, больше витаминов и яркого вкуса.",
                    IsDiscount = true,
                    Photo = "../my_images/goroh.png",
                    NewPrice = 60
                });
                Products.Add(new Product
                {
                    Name = "Наполнитель Каждый День для кошачьего туалета",
                    Price = 60,
                    Weight = 2500,
                    Description = "Минеральный наполнитель для кошачьих туалетов. Впитывающий. 1 кг наполнителя впитывает до 5 л жидкости. Нейтрализует неприятные запахи. Гипоаллергенный. Не прилипает к шерсти и лапкам. Рекомендован для взрослых кошек и котят.",
                    IsDiscount = false,
                    Photo = "../my_images/cat.png"
                });
                Products.Add(new Product
                {
                    Name = "Антифриз Sintec LUX",
                    Price = 723,
                    Weight = 5000,
                    Description = "Антифриз LUX предназначен для всех современных двигателей, подвергающихся высокой нагрузке, особенно алюминиевых. Антифриз LUX обеспечивает прекрасную защиту системы охлаждения от замерзания, коррозии и перегревания, эффективно защищает от образования отложений в охлаждающих каналах, в отсеке двигателя, в радиаторе и водяном насосе.",
                    IsDiscount = false,
                    Photo = "../my_images/sintec.png"
                });
                Products.Add(new Product
                {
                    Name = "Грудка цыпленка-бройлера филе",
                    Price = 272,
                    Weight = 800,
                    Description = "Охлажденное филе грудки цыпленка-бройлера подходит для приготовления огромного множества блюд. Варите бульоны для супов, добавляйте его в пасты или запекайте в духовке с овощами и сыром — филе будет вкусным в любом виде. Кроме того, белое мясо с минимальным содержанием жиров и калорий — это идеальный диетический продукт.",
                    IsDiscount = false,
                    Photo = "../my_images/chicken.png"
                });
                Products.Add(new Product
                {
                    Name = "Крабовые палочки Vici замороженные",
                    Price = 150,
                    Weight = 240,
                    Description = "Сочное и удивительно вкусное охлажденное крабовое мясо, которое станет отличной закуской как в самостоятельном виде, так и в качестве ингредиента для различных салатов из морепродуктов. Продукт не содержит ГМО и изготавливается на основе натурального рыбного фарша. Продукт полностью готов к употреблению и упакован в удобный вакуумный пакет. Эти крабовые палочки станут хорошим вариантом диетического питания, так как содержат небольшое количество калорий и жиров.",
                    IsDiscount = true,
                    Photo = "../my_images/crabs.png",
                    NewPrice = 95
                });
                Products.Add(new Product
                {
                    Name = "Мидии Vici Чилийские очищенные варено-мороженые",
                    Price = 284,
                    Weight = 400,
                    Description = "Люди могут представить себе жизнь без хорошей еды, но имеет ли она смысл вообще? Абсолютно нет! По этой причине компания создает разнообразный ассортимент продукции в VIČI.",
                    IsDiscount = false,
                    Photo = "../my_images/vici.png"
                });
                Products.Add(new Product
                {
                    Name = "Творожный сыр Violette с креветками 70%",
                    Price = 120,
                    Weight = 140,
                    Description = "Нежный, натуральный творожный сыр с ярким вкусом креветок. Рекомендуем добавить маслины и свежий огурец.",
                    IsDiscount = true,
                    Photo = "../my_images/violette.png",
                    NewPrice = 75
                });
                Products.Add(new Product
                {
                    Name = "Сырок творожный Б.Ю. Александров ванильный глазированный 26%",
                    Price = 55,
                    Weight = 50,
                    Description = "Глазированный творожный сырок в молочном шоколаде. Обладает нежным ванильным вкусом.",
                    IsDiscount = true,
                    Photo = "../my_images/tvorog.png",
                    NewPrice = 40
                });
            }
            SaveChanges();
        }
    }
}
