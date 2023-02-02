using v21;

Kalkulator hitung = new Kalkulator();

//hitung.tambah();
//hitung.kurang();

Console.Write("masukan panjang : ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("masuk lebar : ");

Rumus rumus = new Rumus();
int luas = rumus.persegiPanjang(p, 1);

Console.WriteLine($"luas persegi panjang dengan p = {p} dan l = {1} adalah {luas}");