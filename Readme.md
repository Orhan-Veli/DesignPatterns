# Tasarım Desenleri
> Bu repo da insanların türkçe olarak tasarım desenlerini anlamasını ve projelerine entegre etmesini sağlamaya çalışacağım.

## İçindekiler
* [Abstract Factory](#abstract-factory)
* [Adapter](#adapter)

## Abstract Factory

### Abstract Factory Pattern Nedir?

Bir fabrikanız olduğunu düşünün bu fabrikada kullanılan her bir ürün için sınıflarınız olduğunu düşünün, bu ürünlerin her biri için arayüz tanımlayıp o arayüzler üzerinden işlemlerinizi yürütüyorsunuz.

### Abstract Factory Pattern Ne Zaman Kullanılır?

Factory method patternini kullandınız fakat artık ürün sayınız artmaya başladı ve kullandığınız pattern size yeterli gelmemeye başladı. Burada abstract factorye geçme zamanınız gelmiştir.

### Abstract Factory Uygulama Açıklaması

Shape adında bir arayüz oluşturuyoruz, bu arayüzü Rectangle, Square, RoundedRectangle, RoundedSquare kalıtım alıyor. Sonrasında AbstractFactory adında bir sanal sınıf oluşturup ShapeFactory ve RoundedShapeFactory sınıflarımıza kalıtım olarak alıyoruz.Oluşturduğumuz FactoryProducer sınıfı aracılığıyla AbstractFactory sınıfı üzerinden hangi şekili üreteceğimizi söylüyoruz. Son olarak konsol üzerinden hangi nesneyi üreteceğimizi söyleyerek işlemlerimizi tamamlıyoruz. 
