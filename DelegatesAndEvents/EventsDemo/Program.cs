
//// waarom/wat voor events?
//// - foutafhandeling
//// - functionele redenen
//// - diagnostische zaken
//// - security

//var fsw = new FileSystemWatcher(@"C:\temp");
//fsw.Created += (sender, args) =>
//{
//    Console.WriteLine("Bestand aangemaakt! " + args.FullPath);
//};
//fsw.Changed += (sender, args) =>
//{
//    Console.WriteLine("Bestand veranderd! " + args.FullPath);
//};
//fsw.Deleted += (sender, args) =>
//{
//    Console.WriteLine("Bestand verwijderd! " + args.FullPath);
//};
//fsw.Renamed += (sender, args) =>
//{
//    Console.WriteLine($"Bestand aangemaakt! Van {args.OldName} naar {args.Name}");
//};
//fsw.EnableRaisingEvents = true;


//// don't do this at home.
//while (true)
//{
//    Thread.Sleep(50);
//}