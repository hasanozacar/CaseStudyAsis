# CaseStudyAsis.

## Kısa açıklama
Bu repo, işe alım sürecindeki Case Study sorularının .NET ile adım adım, testlerle birlikte çözümlerini içerir. Her task küçük ve okunabilir commit’lerle eklendi; amaç test edilebilir ve kolay incelenebilir bir repo sunmaktır.

---

## İçerik / klasör yapısı
```text
CaseStudyAsis/
├─ CaseStudy.sln
├─ README.md
├─ src/
│  ├─ CaseStudyApp/                 (Console uygulaması)
│  │  ├─ Program.cs
│  │  ├─ CaseStudyApp.csproj
│  │  ├─ Examples/
│  │  │  └─ IndexAccessExample.cs
│  │  ├─ Models/
│  │  │  ├─ Person.cs
│  │  │  └─ Animals/
│  │  │     ├─ Animal.cs
│  │  │     ├─ Dog.cs
│  │  │     └─ Cat.cs
│  │  ├─ Services/
│  │  │  └─ CountService.cs
│  │  └─ Utils/
│  │     ├─ ListUtils.cs
│  │     └─ MaxListEmptyException.cs
│  └─ CaseStudyApp.Tests/           (xUnit test projesi)
│     ├─ AssemblyInfo.cs            
│     ├─ IndexAccessExampleTests.cs
│     ├─ PersonTests.cs
│     ├─ CountServiceTests.cs
│     ├─ ListUtilsTests.cs
│     └─ AnimalTests.cs     
```

---

## Gereksinimler
- **.NET SDK:** Öneri .NET 8. Gerekirse `TargetFramework` değerini `net6.0` yapabilirsiniz.
- **Git:** Versiyon kontrol için.
- **Editör:** (Opsiyonel) VS Code veya Visual Studio.

---

## Nasıl çalıştırılır (lokal)

### Repo klonla veya kopyala
```bash
git clone <repo-url>
cd CaseStudyAsis
```

### Build
```bash
dotnet build
```

### Uygulamayı çalıştır (demo çıktılarını görmek için)
```bash
dotnet run --project src/CaseStudyApp
```

---

## Testler

### Tüm testleri çalıştır
```bash
dotnet test
```

> Not: Testler Console.SetOut kullandığı için, test projesinde paralel test çalıştırma devre dışı bırakılmıştır.  
> (Bkz: `src/CaseStudyApp.Tests/AssemblyInfo.cs` içinde `[assembly: CollectionBehavior(DisableTestParallelization = true)]`)  
> Böylece Console çıktısı yakalama (`StringWriter`) sırasında testler çakışmaz.

### Tek bir testi çalıştırmak için
```bash
dotnet test --filter "FullyQualifiedName~CaseStudyApp.Tests.PersonTests"
```

---

## Görevlerin kısa özeti
- **Task1: IndexAccessExample:** Dizin hatasını `try/catch` ile yakalama. Test edilebilirlik için `RunWithArray(int[]? numbers)` eklendi; `Run()` orijinal davranışı korur.
- **Task2: Person sınıfı:** `Name (string)`, `Age (int)`. Constructor validasyonları: `Name` için null/boş kontrolü, `Age` için mantıksal sınır (0–150).
- **Task3: CountService:** Üç asenkron metodu aynı anda `Task.WhenAll` ile çalıştırıp sonuçları yazdırma.
- **Task4: ListUtils.GetMax:** Boş liste için `null`; istenirse exception fırlatan `GetMaxOrThrow`.
- **Task5: Animal polimorfizmi:** `Animal` abstract sınıfı ve `Dog/Cat` implementasyonları.
