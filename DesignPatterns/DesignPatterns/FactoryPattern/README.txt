//Factory Pattern
    //Creational Pattern
    //Helps to create Objects


	client code:
if (invoicetype=="1")
{
s= new invoicetype1();
}
else if (invoicetype=="2")
{
s= new invoicetype2();
}

Remove all new in client code (create a seperate class to retun a invoice)
Remove exposing all invoice types to clinet code (expose the interface of invoice type not individual incoice type classes)