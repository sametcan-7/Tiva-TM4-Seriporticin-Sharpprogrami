# Tiva-TM4-Seriporticin-Sharpprogrami
Tiva TM4 mikroişlemcisi ile uyumlu bir seri port uygulaması geliştirmek amacıyla, C# programlama dili kullanılarak Sharp Developer geliştirme ortamında bir yazılım tasarlanmıştır. Bu proje, Tiva TM4 mikroişlemcisinin seri port iletişim yeteneklerini tam anlamıyla kullanabilmek ve kullanıcıya kolay bir arayüz sunabilmek amacıyla detaylı bir şekilde hazırlanmıştır. Uygulamanın çalışabilmesi için, bilgisayara bağlı olan mikroişlemcinin COM numarasının doğru bir şekilde belirlenmesi gerekmektedir. Çünkü bilgisayardan bilgisayara farklılık gösterebilen bu COM numarası, kullanıcı tarafından yazılım arayüzüne doğru bir şekilde girilmediği takdirde iletişim sağlanamaz.

Tasarım sırasında dikkat edilmesi gereken bir diğer önemli nokta ise kullanıcı arayüzünde yer alan bileşenlerin adlandırılmasıdır. Örneğin, programda kullanılan butonlar veya etiketler (labels) üzerindeki isimlerin değiştirilmesi durumunda, yazılımın kaynak kodunda da bu değişikliklerin uyumlu bir şekilde yapılması gerekmektedir. Aksi takdirde, programın çalışmasında hatalar ortaya çıkabilir. Bu durum, hem yazılımın stabilitesini sağlamak hem de kullanıcı deneyimini geliştirmek açısından önemlidir.

Tasarımın temel amacı, kullanıcıların mikroişlemci ile seri port üzerinden kolayca iletişim kurmasını sağlamaktır. Yazılım, kullanıcı dostu bir arayüzle geliştirilmiş olup, port seçiminden veri iletişimine kadar tüm adımları basit ve anlaşılır bir hale getirmektedir. Örnek bir tasarımın görünümü aşağıda sunulmuş olup, uygulama bu yapıya göre özelleştirilebilir. Bu süreçte yapılan her değişikliğin kaynak kod ile uyumlu olması gerektiği unutulmamalıdır.
![Ekran görüntüsü 2025-01-18 230959](https://github.com/user-attachments/assets/dbaaca7d-2bc9-47de-88e1-ff4bce81108d)
