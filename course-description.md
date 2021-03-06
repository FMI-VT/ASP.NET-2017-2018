# Курсов Проект по Уеб програмиране с .NET

### Общи изисквания

- Тема на проекта: по избор
- Визуалното оформяне (html & css) няма да се оценява
- Кода трябва да се "host-ва" в публично достъпно _git_ хранилище. Безплатни услуги:

   - [GitHub](https://github.com/) - препоръчително
   - [GitLab](https://about.gitlab.com/)
   - [BitBucket](https://bitbucket.org/)
   - [VisualStudio Team Services](https://www.visualstudio.com/team-services/)

- При представяне на проекта трябва да имате поне 10 commit-a в различни дати
- Добавете README файл, който да описва целта на проекта и специфични изисквания за конфигуриранте / стартиране
- Добавете ER диаграми на базата данни, която сте проектирали
- Добавете скици на графичния интерфейс (data grids, форми за добавяне / редакция) 
- Проекта ви трябва да използва поне три таблици
- Solution-а за проекта трябва да включва следните проекти:

    - DB (или Database)
    - DataAccess (използва се EntityFramework)
    - Repositories
    - Web Applicaiton (MVC проект)
    - Services (Service Layer, по желание)

### Изисквания към приложението

- Регистрация на потребител
- Логин форма (удостоверяване на идентичност)
- CRUD интерфейс + data grid за поне един от обектите съхранявани в БД
- При търсене резултата да се показва на "порции" (страници) и данните да могат да се сортират по избран критерий
- Адекватни валидации по ваша преценка, според вида на данните, които съхранявате в БД

### Бонус условия

- Ролево-базиран контрол на достъпа, достъпни роли: Администратор, Потребител
- Скриване на контролите за забранени действия (за роля Потребител)
