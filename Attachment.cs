using System.Text;


// Q01
string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);


// Q02
string s1 = "Clean Code";
string s2 = "Clean Code";
Console.WriteLine(ReferenceEquals(s1, s2));




// Q03
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");
Console.WriteLine(sb);



// Q04
sb.Replace("Book List", "Library");
Console.WriteLine(sb);



// Q05
string title2 = "Clean Code";
int pages2 = 464;
string result2 = "Book: " + title2 + ", Pages: " + pages2;
Console.WriteLine(result2);




// Q06
string title3 = "Clean Code";
int pages3 = 464;
string result3 = $"Book: {title3}, Pages: {pages3}";
Console.WriteLine(result3);




// Q07
string title4 = "Clean Code";
int pages4 = 464;
string result4 = string.Format("Book: {0}, Pages: {1}", title4, pages4);
Console.WriteLine(result4);




// Q08

int pages5 = 464;
if (pages5 > 300)
    Console.WriteLine("Long Book");
else
    Console.WriteLine("Short Book");


// Q09
int pages9 = 464;
bool isAvailable = true;
if (pages9 > 300 && isAvailable == true)
    Console.WriteLine("You can borrow this book");




// Q10
string title10 = "Refactoring";
switch (title10)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}


// Q11
int pages11 = 464;
string sizeLabel = pages11 > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);



// Q12
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + books[i]);
}



// Q13
int ii = 0;
while (ii < books.Length)
{
    Console.WriteLine(books[ii]);
    ii++;
}

// Q14
int count = 0;
do
{
    Console.WriteLine("Checking book...");
    count++;
}
 while (count < 3);

// Q15
foreach (string book in books)
{
    Console.WriteLine(book);
}

// Q16

foreach (string book in books)
{
    if (book == "Refactoring")
        break;
    Console.WriteLine(book);
}

// Q17
foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
        continue;
    Console.WriteLine(book);
}

// Q18
