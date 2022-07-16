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
* [Data Access Object](#data-access-object)
* [Facade](#facade)
* [Filter](#filter)
* [Flyweight](#flyweight)
* [Front Controller](#front-controller)
* [Intercepting Filter](#intercepting-filter)
* [Interpreter](#interpreter)
* [Iterator](#iterator)
* [Mediator](#mediator)
* [Memento](#memento)
* [Mvc](#mvc)

## Abstract Factory

### Abstract Factory Pattern Nedir?

Bir fabrikanız olduğunu düşünün bu fabrikada kullanılan her bir ürün için sınıflarınız olduğunu düşünün, bu ürünlerin her biri için arayüz tanımlayıp o arayüzler üzerinden işlemlerinizi yürütüyorsunuz.

### Abstract Factory Pattern Ne Zaman Kullanılır?

Factory method patternini kullandınız fakat artık ürün sayınız artmaya başladı ve kullandığınız pattern size yeterli gelmemeye başladı. Burada abstract factorye geçme zamanınız gelmiştir.

### Abstract Factory Uygulama Açıklaması

IShape adında bir arayüz oluşturuyoruz, bu arayüzü Rectangle, Square, RoundedRectangle, RoundedSquare kalıtım alıyor. Sonrasında AbstractFactory adında bir sanal sınıf oluşturup ShapeFactory ve RoundedShapeFactory sınıflarımıza kalıtım olarak alıyoruz.Oluşturduğumuz FactoryProducer sınıfı aracılığıyla AbstractFactory sınıfı üzerinden hangi şekili üreteceğimizi söylüyoruz. Son olarak Program üzerinden hangi nesneyi üreteceğimizi söyleyerek işlemlerimizi tamamlıyoruz. 

# Adapter

## Adapter Pattern Nedir?

Birbiri ile uyumsuz olan arayüzlerin beraber kullanılmasını sağlar.

## Adapter Pattern Ne Zaman Kullanılır?

Uygulamada kullanılan bir kütüphane arayüzümüz var. Ekstra bir arayüz eklemek istedik fakat uygulama kütüphanesi içerisinden bunu düzeltemedik. Burada Adapter tasarım deseni devreye giriyor. Hazır olan kütüphane arayüzüne dokunmadan kendi arayüzümüzü entegre ediyoruz.

## Adapter Pattern Uygulama Açıklaması

Elimizde IMediaPlayer arayüzümüz var ve bundan AudioPlayer kalıtım alıyor. AudioPlayer mp3 formatında müzik çalabiliyor. 

Elimizde ikinci olarak IAdvancedMediaPlayer arayüzümüz var, bu arayüzü VlcPlayer ve Mp4Player kalıtım alıyor. Bu classlarımız vlc ve mp4 çalabiliyor.

Biz AudioPlayerın diğer formatları da çalmasını istiyoruz. Bu yüzden MediaAdapter adında bir class ürettik. MediaAdapter IMediaplayer arayüzünü kalıtım alıyor ve AdvancedMediaPlayer sınıfını kullanıyor.

AudioPlayer sınıfına istediğimiz MediaPlayerı yolluyoruz. O da hangi formatta çalması gerektiğini bilip çalmaya başlıyor.

# Bridge

## Bridge Pattern Nedir?

Bir köprü sanal sınıfı ile farklı arayüzlere ulaşmak için kullanılan tasarım desenidir.

## Bridge Pattern Ne Zaman Kullanılır?

Client tarafından direkt farklı arayüzlere erişmek istemiyorsanız ve yapınızı bir sanal sınıf aracılığıyla kurgulamak istiyorsanız.

## Bridge Pattern Uygulama Açıklaması

IDrawAPI arayüzümüz burada bridge entegratörü olarak işlev görüyor. RedCircle ve GreenCircle bu arayüzü kalıtım alıyor.
Shape sanal sınıfımız IDrawAPI arayüzümüzü kullanıyor ve Program uygulamamızda, bu sınıf üzerinden farklı sınıfları çağırıyor.

# Builder

## Builder Pattern Nedir?

Karışık bir yapıda oluşan constructer yapısını ayırmamızı sağlayan tasarım deseni.

## Builder Pattern Ne Zaman Kullanılır?

Karmaşık bir yapınız var ise constructerda biriken parametreler, arayüzler ve sınıflar var ise bu desen tam size göre.

## Builder Pattern Uygulama Açıklaması

Toy adında bir model oluşturuyoruz. IToyBuilder arayüzümüzü oluşturup iki adet ToyABuilder ve ToyBBuilder sınıflarımıza entegre ediyoruz. Oluşturduğumuz ToyCreator sınıfımız bir toy builder sınıfı alıyor ve Program üzerinden bir toy üretiyor.

# Business Delegate

## Business Delegate Pattern Nedir?

Sunum katmanı ile iş katmanını birbirinden ayırmak için kullanılan patterndir.

## Business Delegate Pattern Ne Zaman Kullanılır?

Sunum katmanı ile iş katmanınız birbiri içerisindeyse, kod karmaşıklığı yaratıyorsa. Bu pattern tam size göre.

## Business Delegate Pattern Uygulama Açıklaması

Burada EJBService ve JMSService adında iki tane sınıf oluşturuyoruz. Bu sınıflar oluşturduğumuz IBusinessService arayüzünü kalıtım alıyor. Sonrasında BusinessLookup sınıfı ile hangi sınıfı çekeceğimizi söylüyoruz. BusinessDelegate sınıfı ile BusinessLookup ve BusinessService i kullanıp, lookup üzerinden sınıfı çağırıp service üzerindende işlemimizi yürütüyoruz. 

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

Bir IOrder arayüzü oluşturuyoruz bu arayüz command gibi davranıyor. Stock adında bir sınıf oluşturuyoruz ve bu sınıf istek gibi hareket ediyor. BuyStock ve SellStock sınıflarımız command işlemlerini yürütüyor. Broker sınıfımız çağırıcı olarak işlev görüyor ve sipariş alıyor. Broker sınıfı command tasarım desenini kullanarak hangi objeye göre işlem yapacağını belirliyor.

# Composite Entity

## Composite Entity Nedir?

Birden fazla parça halinde olan nesnelerin tek bir nesne gibi hareket etmesini sağlayan tasarım desenidir.

## Composite Entity Ne Zaman Kullanılır?

Birden fazla nesnenin bulunduğu bir yapınız varsa ve karmaşıklıktan kurtulmak istiyorsanız bu tasarım deseni tam size göre.

## Composite Entity Uygulama Açıklaması

Composite Entity adında bir sınıf oluşturacağız, bu sınıfımız tasarım desenimizi taklit edecek. CoarseGrainedObject sınıfımız içinde önceden oluşturduğumuz sınıfları barındıracak. Sonrasında Client sınıfımız üzerinden CompositeEntity sınıfını kullanarak Composite Entity tasarım desenini uyguluyoruz.

# Data Access Object

## Data Access Object Nedir?

Veri ve iş sınıflarımızın birbirinden ayrılması için kullanılan tasarım desenidir.

## Data Access Object Ne Zaman Kullanılır?

Veri ve iş sınıflarınız birbiri ile iç içeyse, kod okunabilirliği zorlaştırıyor veya karmaşıklaştırıyorsa bu tasarım deseni tam size göre.

## Data Access Object Uygulama Açıklaması

Bir tane Student objesi oluşturacağuz ve bu obje model görevi görecek. Sonrasında IStudentDao arayüzü oluşturup bu arayüzü StudentDao sınıfımız kalıtım alacak. Program sınıfımız tasarım desenini StudentDao sınıfı üzerinden yürütecek.

# Decorator

## Decorator Pattern Nedir?

Kullanıcıya hali hazırda olan bir mimariye yeni bir özellik eklemesini sağlayan tasarım desenidir. 

## Decorator Pattern Ne Zaman Kullanılır?

Hali hazırda olan bir mimarinize yeni bir özellik kazandırmak istiyorsanız. Bu tasarım desenini kullanabilirsiniz.

## Decorator Pattern Uygulama Açıklaması

Bir adet IShape adında bir arayüz oluşturuyoruz, bu arayüzü Circle ve Rectangle sınıfımız kalıtım alıyor. Sonrasında ShapeDecorator sanal sınıf oluşturup, bu sınıf içinde IShape arayüzümüzü kullanıyoruz. RedShapeDecorator sınıfımız ShapeDecorator sanal sınıfını kalıtım alıyor ve program sınıfı üzerinden decorator patterni kullanıyoruz.

# Facade

## Facade Pattern Nedir?

Bu tasarım desenimiz sistemdeki karmaşıklığı saklayıp, müşteriye sisteme erişebileceği bir arayüz sunmaktadır.

## Facade Pattern Ne Zaman Kullanılır?

Karmaşık bir yapınız olduğunu düşünün, sürekli farklı bir sisteme gitmek yerine bunu, Facade tasarım deseni üzerinden altsistemlere gitmek için kullanabilirsiniz.

## Facade Pattern Uygulama Açıklaması

IShape adında bir arayüz oluşturuyoruz. Bu arayüzü Circle, Rectangle, Square kalıtım alıyor. ShapeMaker sınıfımız IShape arayüzü üzerinde alt sınıfları kullanarak Facade tasarım desenini yürütüyor.

# Factory Method

## Factory Method Pattern Nedir?

Bir nesne yaratmak için tek bir arayüz kullanan ve altsınıflarda oluşturulacak nesne türlerinin bu arayüzü değiştirebilmesine izin veren tasarım desenidir. 

## Factory Method Pattern Ne Zaman Kullanılır?

Bir adet temel sınıfımız olduğunu düşünelim ve bunun alt sınıfları olsun. Biz burada bir alt sınıfı döndermek istiyorsak bu tasarım deseni tam bize göre.

## Factory Method Pattern Uygulama Açıklaması

IShape adında bir arayüzümüz var bu arayüzü Circle, Square,Rectangle sınıfı kullanıyor. ShapeFactory sınıfımıza hangi alt sınıfı kullanacağımız söylüyoruz ve o da bize istediğimiz sınıfı döndürüyor.

# Filter 

## Filter Pattern Nedir?

Bu tasarım deseni yazılımcıların mantıksal operasyonlarla farklı kriterdeki objeleri filtrelemek amacıyla kullandığı tasarım desenidir.

## Filter Pattern Ne Zaman Kullanılır?

Filreleme işlemlerinde kullanılan tasarım desenidir. 

## Filter Pattern Uygulama Açıklaması

Bir tane Person objesi oluşturalım, oluşturduğumuz ICriteria arayüzünü filtreleme işlemlerinde kullanacağımız sınıflar kalıtım alıyor. Program sınıfında bu arayüzü kullanarak hangi sınıfa göre filtreleme işlemi yapacağımızı belirtiyoruz.

# Flyweight

## Flyweight Pattern nedir?

Bu tasarım deseni genel olarak oluşturulan obje sayısını azaltmak, ramde kullanılan yeri azaltmak ve performansı arttırmak için kullanılır. 

## Flyweight Pattern Ne Zaman Kullanılır?

Birden fazla aynı tipte obje kullanacaksanız bu tasarım deseni tam size göre.

## Flyweight Pattern Uygulama Açıklaması

IShape adında bir arayüz oluşturuyoruz. Bu arayüzü Circle adında sınıfımız kalıtım alıyor. ShapeFactory sınıfımız IShape arayüzünü kullanarak oluşturulacak Circle objesini önce kontrol ediyor. Eğer varsa olanı dönüyor yoksa objeyi oluşturup dönüş yapıyor.

# Front Controller

## Front Controller Pattern Nedir?

Bu tasarım deseni merkezleşmiş bir istek yönetim mekanizması kullanıyor. Bu mekanizma sayesinde tüm istekler tek bir işleyici tarafından karşılanıyor.

### Front Controller:

Bütün istekleri işleyen, karşılayan sınıf.

### Dispatcher

Bu sınıfı genellikle Front Controller kullanılır ve bazı spesifik objeleri işlemesi için başka sınıflara yönlendirir.

###

İsteklerin oluşturduğu objeler.

## Front Controller Pattern Ne Zaman Kullanılır?

Bütün istekleri tek bir tarafta işlemek istiyorsanız bu tasarım deseni tam size göre.

## Front Controller Pattern Uygulama Açıklaması

Oluşturduğumuz sınıflarımız tasarım desenini olduğu gibi kullanılmaktadır.

# Intercepting Filter

## Intercepting Filter Pattern Nedir?

Bu tasarım deseni gelen istek ve yanıtları önceden ve sonradan işlemek için kullanılır. 

## Intercepting Filter Pattern Ne Zaman Kullanılır?

Genellikle gelen istekleri veya yanıtları önceden bir işleme tabi tutmak istiyorsak bu tasarım deseni tam size göre.

## Intercepting Filter Pattern Uygulama Açıklaması

### Filter

Arayüzümüz aracılığıyla gelen isteği nasıl işleyeceğimize karar veriyoruz.

### Filter Chain

Birden fazla filtrelenecek isteği taşıyor ve nasıl işleneceğinize karar veriyor.

### Target

Target sınıfımız gelen istekleri işliyor.

### Filter Manager

Filter Manager sınıfımız ise filter chain ve filter sınıflarını yönetiyor.

### Client

Client sınıfımız ise istek atan sınıfımız konumunda.

# Interpreter

## Interpreter Tasarım Deseni Nedir?

Bu tasarım deseni dil çevirmelerinde yaşadığımız sıkıntıyı çözmek için kullanılıyor.

## Interpreter Tasarım Deseni Ne Zaman Kullanılır?

Eğer dil çevirme konusunda bir tasarım deseni arıyorsanız bu tasarım deseni tam size göre.

## Interpreter Tasarım Deseni Uygulama Açıklaması

IExpression arayüzü yardımıyla işlemlerimizi gerçekleştiriyoruz. TerminalExpression sınıfımız burada Interpreter tasarım desenini kullanmaktadır. Diğer sınıflarımız kombinasyon sınıfları olarak kullanılmaktadır.

# Iterator

## Iterator Pattern Nedir?

Bu tasarım deseni bir koleksiyon nesnesinin öğelerine, altta yatan temsilini bilmeye gerek duymadan sıralı bir şekilde erişmek için kullanılır.

## Iterator Pattern Ne Zaman Kullanılır?

Eğer uygulamanızda birden fazla nesne varsa ve birbiri ile olan bağlantılarını en aza indirmek istiyorsanız, bu tasarım deseni tam size göre.

## Iterator Pattern Uygulama Açıklaması

IIterator ve IContainer arayüzlerimizi oluşturuyoruz. Bu arayüzler navigasyon methodunu anlatıyor diğeri ise iteratoru dönderiyor. Sınıflarımız bu arayüzleri kalıtım alıyor ve kullanıyor. NameRepository sınıfımız üzerinden iterator tasarım desenini aktif ediliyor.

# Mediator

## Mediator Pattern Nedir?

Birden fazla obje ve ya sınıfın haberleşme karmaşıklığını çözmek için bu tasarım deseni kullanılır.

## Mediator Pattern Ne Zaman Kullanılır?

Genel olarak CQRS tasarım deseni bu tasarım desenini kullanıyor. Genellikle Constructer oluşan sınıf kalabağını azaltmak için kullanılabilir.

## Mediator Pattern Uygulama Açıklaması

Uygulamamızda bulunan User sınıfımız Chatroom sınıfını kullanarak mesaj iletimi gerçekleştiririz. User sınıfımız kullanıcılar arasındaki iletişimi sağlayarak mediator tasarım desenini kullanıyor.

# Memento

## Memento Pattern Nedir?

Bu tasarım deseni nesneyi bir önceki durumuna geri çevirmek için kullanılır.

## Memento Pattern Ne Zaman Kullanılır?

Bir nesneyi önceki durumuna çevirmek istiyorsak bu tasarım deseni tam bize göre.

## Memento Pattern Uygulama Açıklaması

Burada 3 adet aktif rol oynayan sınıfımız var. Memento sınıfımız ger çevrilecek objenin durumunu tutuyor. Caretaker sınıfımız Memento sınıfımızdaki objemizi geri çevirir. Originator sınıfımız yeni bir tane durum yaratır ve memento sınıfında saklar.

# Mvc

## Mvc Pattern Nedir?

Bu tasarım deseni modeli, görüntüyü ve kontrolcüyü birbirinden ayırmak için kullanılır.

## Mvc Pattern Ne Zaman Kullanılır?

Bu pattern genel olarak asp.net mvc olarak bilinir. 

## Mvc Pattern Uygulama Açıklaması

Student sınıfımız model olarak kullanılıyor. StudenController sınıfımız gelen istekleri karşılıyor ve işliyor. Sonrasında ise StudentView i güncelliyor.

