using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingFEApplication
{
    readonly pubsEntities4 entities;
    public Program()
    {
        entities = new pubsEntities4();

    }
    void PrintAuthors()
    {
        var authors = entities.authors.ToList();
        foreach (var auth in authors)
        {
            Console.WriteLine(auth.au_id);
            Console.WriteLine(auth.au_fname + " " + auth.au_lname);
            Console.WriteLine(auth.address);
            Console.WriteLine(auth.state);
            Console.WriteLine("---------------------------");
        }
    }
    
}
