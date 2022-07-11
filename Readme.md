# Tasarım Desenleri
> Bu repo da insanların türkçe olarak tasarım desenlerini anlamasını ve projelerine entegre etmesini sağlamaya çalışacağım.

## İçindekiler
* [Abstract Factory](#abstract-factory)
* [Adapter](#adapter)
* [Bridge](#bridge)
* [Builder](#builder)
* [Business Delegate](#business-delegate)
* [Chain Of Responsibility](#chain-of-Responsibility)
* [Command](#command)
* [Composite Entity](#composite-entity)

## Abstract Factory

### Abstract Factory Pattern Nedir?

Bir fabrikanız olduğunu düşünün bu fabrikada kullanılan her bir ürün için sınıflarınız olduğunu düşünün, bu ürünlerin her biri için arayüz tanımlayıp o arayüzler üzerinden işlemlerinizi yürütüyorsunuz.

### Abstract Factory Pattern Ne Zaman Kullanılır?

Factory method patternini kullandınız fakat artık ürün sayınız artmaya başladı ve kullandığınız pattern size yeterli gelmemeye başladı. Burada abstract factorye geçme zamanınız gelmiştir.

### Abstract Factory Uygulama Açıklaması

Shape adında bir arayüz oluşturuyoruz, bu arayüzü Rectangle, Square, RoundedRectangle, RoundedSquare kalıtım alıyor. Sonrasında AbstractFactory adında bir sanal sınıf oluşturup ShapeFactory ve RoundedShapeFactory sınıflarımıza kalıtım olarak alıyoruz.Oluşturduğumuz FactoryProducer sınıfı aracılığıyla AbstractFactory sınıfı üzerinden hangi şekili üreteceğimizi söylüyoruz. Son olarak konsol üzerinden hangi nesneyi üreteceğimizi söyleyerek işlemlerimizi tamamlıyoruz. 


# Adapter

## Adapter Pattern Nedir?

Birbiri ile uyumsuz olan arayüzlerin beraber kullanılmasını sağlar.

## Adapter Pattern Ne Zaman Kullanılır?

Uygulamada kullanılan bir kütüphane arayüzümüz var. Ekstra bir arayüz eklemek istedik fakat uygulama kütüphanesi içerisinden bunu düzeltemedik. Burada Adapter tasarım deseni devreye giriyor. Hazır olan kütüphane arayüzüne dokunmadan kendi arayüzümüzü entegre ediyoruz.

## Adapter Pattern Uygulama Açıklaması

Elimizde MediaPlayer arayüzümüz var ve bundan AudioPlayer kalıtım alıyor. AudioPlayer mp3 formatında müzik çalabiliyor. 

Elimizde ikinci olarak AdvancedMediaPlayer arayüzümüz var, bu arayüzü VlcPlayer ve Mp4Player kalıtım alıyor. Bu classlarımız vlc ve mp4 çalabiliyor.

Biz AudioPlayerın diğer formatları da çalmasını istiyoruz. Bu yüzden MediaAdapter adında bir class ürettik. MediaAdapter Mediaplayer arayüzünü kalıtım alıyor ve AdvancedMediaPlayer sınıfını kullanıyor.

AudioPlayer sınıfına istediğimiz MediaPlayerı yolluyoruz. O da hangi formatta çalması gerektiğini bilip çalmaya başlıyor.

# Bridge

## Bridge Pattern Nedir?

Bir köprü sanal sınıfı ile farklı arayüzlere ulaşmak için kullanılan tasarım desenidir.

## Bridge Pattern Ne Zaman Kullanılır?

Client tarafından direkt farklı arayüzlere erişmek istemiyorsanız ve yapınızı bir sanal sınıf aracılığıyla kurgulamak istiyorsanız.

## Bridge Pattern Uygulama Açıklaması

DrawAPI arayüzümüz burada bridge entegratörü olarak işlev görüyor. RedCircle ve GreenCircle bu arayüzü kalıtım alıyor.
Shape sanal sınıfımız DrawAPI arayüzümüzü kullanıyor ve Konsol uygulamamızda, bu sınıf üzerinden farklı sınıfları çağırıyor.

# Builder

## Builder Pattern Nedir?

Karışık bir yapıda oluşan constructer yapısını ayırmamızı sağlayan tasarım deseni.

## Builder Pattern Ne Zaman Kullanılır?

Karmaşık bir yapınız var ise constructerda biriken parametreler, arayüzler ve sınıflar var ise bu desen tam size göre.

## Builder Pattern Uygulama Açıklaması

Toy adında bir model oluşturuyoruz. IToyBuilder arayüzümüzü oluşturup iki adet ToyABuilder ve ToyBBuilder sınıflarımıza entegre ediyoruz. Oluşturduğumuz ToyCreator sınıfımız bir toy builder sınıfı alıyor ve konsol üzerinden bir toy üretiyor.

# Business Delegate

## Business Delegate Pattern Nedir?

Sunum katmanı ile iş katmanını birbirinden ayırmak için kullanılan patterndir.

## Business Delegate Pattern Ne Zaman Kullanılır?

Sunum katmanı ile iş katmanınız birbiri içerisindeyse, kod karmaşıklığı yaratıyorsa. Bu pattern tam size göre.

## Business Delegate Pattern Uygulama Açıklaması

Burada EJBService ve JMSService adında iki tane sınıf oluşturuyoruz. Bu sınıflar oluşturduğumuz BusinessService arayüzünü kalıtım alıyor. Sonrasında BusinessLookup sınıfı ile hangi sınıfı çekeceğimizi söylüyoruz. BusinessDelegate sınıfı ile BusinessLookup ve BusinessService i kullanıp, lookup üzerinden sınıfı çağırıp service üzerindende işlemimizi yürütüyoruz. 

# Chain Of Responsibility

## Chain Of Responsibility Pattern Nedir?

Gelen istekleri bir dizi işleyici yardımıyla alt sınıflara iletmenizi sağlayan tasarım desenidir.

## Chain Of Responsibility Pattern Ne Zaman Kullanılır?

Bir middleware yapısı kurmanız gerekiyor ya da bir loglama yapmak istiyorsunuz. Bu tasarım deseni ile bu işlemi daha sağlıklı bir şekilde gerçekleştirebilirsiniz.

## Chain Of Responsibility Pattern Uygulama Açıklaması

Bu uygulamamızda loglama işlemini ele aldık. Oluşturduğumuz log sınıflarını AbstractLogger adında sanal bir sınıf üzerinde çağırıp hangi tipe göre loglayacağımızı belirtiyoruz.

# Command

## Command Pattern Nedir?

Gelen bir isteği nesneye dönüştüren ve isteğin kullanıcı tarafından erişilebilir olmasını sağlayan tasarım desenidir.

## Command Pattern Ne Zaman Kullanılır?

Bir windows form, wpf veya unity gibi uygulama tabanlı program kodlarken kullanılabilir.

## Command Pattern Uygulama Açıklaması

Bir Order arayüzü oluşturuyoruz bu arayüz command gibi davranıyor. Stock adında bir sınıf oluşturuyoruz ve bu sınıf istek gibi hareket ediyor. BuyStock ve SellStock sınıflarımız command işlemlerini yürütüyor. Broker sınıfımız çağırıcı olarak işlev görüyor ve sipariş alıyor. Broker sınıfı command tasarım desenini kullanarak hangi objeye göre işlem yapacağını belirliyor.

# Composite Entity

## Composite Entity Nedir?

Birden fazla parça halinde olan nesnelerin tek bir nesne gibi hareket etmesini sağlayan tasarım desenidir.

## Composite Entity Ne Zaman Kullanılır?

Birden fazla nesnenin bulunduğu bir yapınız varsa ve karmaşıklıktan kurtulmak istiyorsanız bu tasarım deseni tam size göre.

## Composite Entity Uygulama Açıklaması

Composite Entity adında bir sınıf oluşturacağız, bu sınıfımız tasarım desenimizi taklit edecek. CoarseGrainedObject sınıfımız içinde önceden oluşturduğumuz sınıfları barındıracak. Sonrasında Client sınıfımız üzerinden CompositeEntity sınıfını kullanarak Composite Entity tasarım desenini uyguluyoruz.