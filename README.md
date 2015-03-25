# SSO-example
Single sign-on demo app with cookie written on MVC c# with no DB
It demonstrate how SSO can work. 
On successful log in, App1 saves cookie, and create url, to acess App2.
On bad login, cookie will be deleted.
Use login name "serge" in App1, any password.
App2 should let you in if you logged in succesfully because it read cookie.
