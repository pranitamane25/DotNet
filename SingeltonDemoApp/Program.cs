using ECommerce;

ProductService svc1=ProductService.CreateInstance();

ProductService svc2=ProductService.CreateInstance();

svc1.Serve();
svc2.Serve();

