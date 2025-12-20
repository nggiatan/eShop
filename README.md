# eShop
## 📝 Project Overview
Dự án xây dựng nền tảng bán lẻ trực tuyến hiện đại, tập trung vào việc xử lý logic Backend mạnh mẽ với .NET 8 và giao diện tối ưu trải nghiệm người dùng với Next.js.

## 🚀 Technologies Used
* **Backend:** .NET 8 Web API (N-Layer Architecture).
* **Frontend:** Next.js (App Router), Tailwind CSS.
* **Database:** MySQL (optimized with Entity Framework Core).
* **Security:** JWT Authentication, Password Hashing.
* **Tools:** Git, Postman, Swagger UI.

## ✨ Core Features
* **Authentication:** Đăng ký/Đăng nhập bảo mật với JWT.
* **Product Management:** Tìm kiếm, lọc sản phẩm và quản lý danh mục (CRUD).
* **Shopping Cart:** Xử lý logic giỏ hàng và thanh toán phía Server.
* **Admin Dashboard:** Quản lý đơn hàng, sản phẩm và thống kê doanh thu.
* **API Documentation:** Tích hợp Swagger UI để dễ dàng theo dõi và kiểm thử API.

## 🏗️ Architecture (N-Layer)
Dự án được tổ chức theo cấu trúc N-Layer nhằm đảm bảo tính bảo trì và mở rộng:
1. **API Layer:** Tiếp nhận và điều hướng Request.
2. **Service Layer:** Xử lý logic nghiệp vụ tập trung.
3. **Repository Layer:** Truy cập và thao tác dữ liệu qua EF Core.

## 🛠️ Installation & Setup
1. Clone repository: `git clone [link-github]`
2. Cấu hình Connection String trong `appsettings.json`.
3. Chạy lệnh: `dotnet run`