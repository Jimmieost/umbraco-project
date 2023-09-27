using Crito.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Crito.Controllers
{
    public class ContactsController : SurfaceController
    {
        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            //Skicka mail start

            //using var mail = new MailService("no-reply@crito.com", "smtp.websupport.se", 465, "jimmie.osth@gmail.com", "password123!");

            //to sender
            //mail.SendAsync(contactForm.Email, "Your contact request was received.", "Hi your request was received and we will contact you as soon as possible.").ConfigureAwait(false);

            // to receiver
            // mail.SendAsync("jimmie.osth@gmail.com", $"{contactForm.Name} sent a contact request", "contactForm.Message").ConfigureAwait(false);

            //skicka mail end

            return LocalRedirect(contactForm.RedirectUrl ?? "/");


        }
    }
}
