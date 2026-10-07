# ACM_01

Customer Management System. Структура классов по лекции 11
«Разделение ответственностей» (Demo_2).

**ACM.BL** (`CMS.BusinessLayer`)
- Сущности: `Customer`, `Product`, `Order`, `OrderItem`, `Address` — только данные и `Validate()`.
- Уровень доступа к данным: `CustomerRepository`, `ProductRepository`, `OrderRepository` — `Retrieve()` / `Save()`.
- `OrderItem` оставлен как на слайде 34 (с `Retrieve()` и `Save()`).

**ACM.BLTest** — юнит-тесты (MSTest).
