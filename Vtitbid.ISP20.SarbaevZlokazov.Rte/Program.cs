using Vtitbid.ISP20.Sarbaev.Route;
//Вариант 10
var routes = new List<Route>();

int counter = 3;

RouteAction.Inicialise(routes, counter);

RouteAction.RouteSort(routes);

RouteAction.RouteFind(routes);

RouteAction.GetInfo(routes);