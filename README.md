# ProjectHive

## Описание
ProjectHive - это платформа для управления задачами и проектами, построенная с использованием Blazor и принципов Domain-Driven Design (DDD), SOLID и GRASP. Платформа включает модули для управления пользователями, задачами и проектами.

## Структура проекта
Проект разделен на несколько слоев для улучшения читаемости и поддерживаемости кода:

- **Domain**: Основная бизнес-логика и правила.
- **Application**: Интерфейсы, юзкейсы и реализации для работы с данными.
- **Infrastructure**: Реализация деталей инфраструктуры, таких как репозитории данных.
- **Presentation**: Визуализация данных и взаимодействие с пользователем.

## Установка
1. Клонируйте репозиторий:
    ```bash
    git clone <URL репозитория>
    ```
2. Перейдите в каталог проекта:
    ```bash
    cd ProjectHive
    ```
3. Установите необходимые зависимости:
    ```bash
    dotnet restore
    ```

## Запуск
Для запуска проекта выполните команду:
```bash
dotnet run --project ProjectHive.Server
```

## Структура каталогов
```plaintext
ProjectHive/
├── ProjectHive.Domain/
│   ├── Entities/
│   │   ├── Task.cs
│   │   ├── Project.cs
│   │   └── User.cs
│   ├── Repositories/
│   │   ├── ITaskRepository.cs
│   │   └── IProjectRepository.cs
│   ├── Services/
│   │   ├── TaskService.cs
│   │   └── ProjectService.cs
│   └── UseCases/
│       ├── ManageTasks.cs
│       └── ManageProjects.cs
├── ProjectHive.Infrastructure/
│   ├── Persistence/
│   │   ├── Repositories/
│   │   │   ├── TaskRepository.cs
│   │   │   └── ProjectRepository.cs
│   │   └── DbContext.cs
│   ├── DependencyInjection/
│   │   └── ServiceCollectionExtensions.cs
├── ProjectHive.Application/
│   ├── Controllers/
│   │   └── TaskController.cs
│   └── Interfaces/
│       └── ITaskService.cs
├── ProjectHive.Client/
│   ├── Pages/
│   │   ├── TaskList.razor
│   │   └── TaskDetails.razor
│   └── Shared/
│       ├── MainLayout.razor
│       └── NavMenu.razor
├── ProjectHive.Server/
│   ├── Controllers/
│   │   └── TaskController.cs
│   └── Program.cs
├── ProjectHive.Shared/
│   ├── Models/
│   │   ├── TaskDto.cs
│   │   ├── ProjectDto.cs
│   │   └── UserDto.cs
├── ProjectHive.sln
└── README.md
```

## Описание компонентов
### Domain
- **Task.cs, Project.cs, User.cs**: Классы сущностей задач, проектов и пользователей.
- **ITaskRepository.cs, IProjectRepository.cs**: Интерфейсы репозиториев задач и проектов.

### Application
- **ManageTasks.cs, ManageProjects.cs**: Юзкейсы для управления задачами и проектами.

### Infrastructure
- **TaskRepository.cs, ProjectRepository.cs**: Реализация репозиториев задач и проектов.
- **DbContext.cs**: Контекст базы данных.

### Presentation
- **TaskController.cs**: Контроллер для управления задачами.
- **TaskList.razor, TaskDetails.razor**: Страницы для отображения списка задач и деталей задачи.
- **MainLayout.razor, NavMenu.razor**: Основная разметка и навигационное меню.

## Лицензия
Этот проект лицензирован под лицензией MIT. Для получения дополнительной информации смотрите файл LICENSE.
