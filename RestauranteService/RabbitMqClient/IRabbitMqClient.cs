 using RestauranteService.Dtos;
 
 namespace RestauranteService.RabbitMq;

 public interface IRabbitMqClient
 {
    void PublicaRestaurante(RestauranteReadDto restauranteReadDto);
 }