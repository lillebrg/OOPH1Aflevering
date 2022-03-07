//Til opgave 2/5 bruger vi Bil2Model og MotorKøretøj2:
//-------------------------------------------------------------------------------------------------
//1:
//List<Bil> Biler = new()
//{
//    new Bil() { HesteKræfter = 60, Mærke = "Toyota", Model = "Aygo" },
//    new Bil() { HesteKræfter = 90, Mærke = "Fiat", Model = "Punto" },
//    new Bil() { HesteKræfter = 175, Mærke = "Audi", Model = "A6" }
//};
//-------------------------------------------------------------------------------------------------

//2:
//List<Bil> Bil = Biler.Where(a => a.HesteKræfter > 60).ToList();
//foreach (Bil bil in Bil)
//{
//    Console.WriteLine("Bilen {0} med modellen {1}, har {2} Hestekræfter", bil.Mærke, bil.Model, bil.HesteKræfter);
//}
//-------------------------------------------------------------------------------------------------
//3:
//Bil B = Biler.FirstOrDefault(a => a.Mærke == "Audi");
//if (Bil != null)
//{
//    Console.WriteLine("BilInfo for mærket Audi er:\n\nMærke: {0}\nModel: {1}\nHestekræfter: {2}", B.Mærke, B.Model, B.HesteKræfter);
//}
