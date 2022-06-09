using BatchFileConverter;

string[] TextFile = System.IO.File.ReadAllLines(@"../../../BaNCS_NFR-Summary-20220518_093037.txt");


List<Batch> batches = new List<Batch>();

foreach (string line in TextFile)
{
    string[] fields = line.Split(" ");

    Batch batch = new Batch();

    batch.Type = fields[0];
    batch.Id = fields[1];

    string status = "";
    for (int i = 2; i < fields.Length; i++)
    {
        if (i != fields.Length - 1)
        {
            status += fields[i] + " ";
        }
        else {
            status += fields[i];
        }
    }
    batch.Status = status;

    batches.Add(batch);

}

foreach (Batch batch in batches)
{
    Console.WriteLine("Batch type: " + batch.Type);
    Console.WriteLine("Batch id: " + batch.Id);
    Console.WriteLine("Batch status: " + batch.Status);
}
