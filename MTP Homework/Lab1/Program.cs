using Lab1;

//Creem cate un produs din ambele categorii
Perisabile produsPerisabil_1 = new Perisabile("Lapte", 3.5, 30, "28-02-2025");
Neperisabile produsNeperisabil_1 = new Neperisabile("Fasole la borcan", 8.68, 50, "12 luni");

//Creem Magazinul si adaugam produse
Magazin store = new Magazin();
store.AddProduct(produsPerisabil_1);
store.AddProduct(produsNeperisabil_1);

//Afiseaza toate produsele
store.DisplayAllProducts();

//Sterge element lista
store.RemoveProduct(produsPerisabil_1);

//Afiseaza din nou toate produsele
Console.WriteLine("\nDupa stergere");
store.DisplayAllProducts();






