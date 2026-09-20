using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    // GET: /HelloWorld/
    public string index()
    {
        return "This is my default action...";
    }
    //
    // GET: /HelloWorld/Welcome/
    {
        return "This is the Welcome action method...";
    }
}