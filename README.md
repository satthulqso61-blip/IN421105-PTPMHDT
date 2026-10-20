- BÀI TẬP CH01 - PHÂN TÍCH YÊU CẦU VÀ DOMAIN MODELING

- 3 Tác nhân mới mở rộng cho dự án
+ GV-01: Giảng viên cố vấn
+ NTT-01: Nhà tài trợ
+ TQ-01: Thủ quỹ CLB

- 5 Câu User Stories và tiêu chí nghiệm thu cho từng cái

- 1. User Story 1 - Tác nhân Giảng viên cố vấn
+ Story: Là một Giảng viên cố vấn, tôi muốn phê duyệt kế hoạch tổ chức sự kiện của CLB để đảm bảo chương trình diễn ra đúng quy chế của nhà trường.
+ Tiêu chí nghiệm thu:
- AC1: Hệ thống hiển thị được đầy đủ thông tin kế hoạch gồm tên sự kiện, mục đích, kinh phí dự trù và nút Duyệt hoặc Từ chối.
- AC2: Khi bấm duyệt thì trạng thái đổi thành Đã duyệt và hệ thống gửi thông báo cho Ban chủ nhiệm.

- 2. User Story 2 - Tác nhân Giảng viên cố vấn
+ Story: Là một Giảng viên cố vấn, tôi muốn xem danh sách đánh giá điểm rèn luyện của các thành viên để khen thưởng những cá nhân xuất sắc.
+ Tiêu chí nghiệm thu:
- AC1: Cho phép sắp xếp danh sách sinh viên theo thứ tự điểm rèn luyện từ cao xuống thấp.
- AC2: Giảng viên bấm chọn được tối đa 5 bạn điểm cao nhất để xuất file khen thưởng.

- 3. User Story 3 - Tác nhân Nhà tài trợ
+ Story: Là một Nhà tài trợ, tôi muốn gửi biểu mẫu đề xuất tài trợ kinh phí trực tuyến để đồng hành cùng các sự kiện lớn của sinh viên.
+ Tiêu chí nghiệm thu:
- AC1: Form nhập bắt buộc phải điền tên công ty, số tiền tài trợ lớn hơn 0 và sự kiện muốn tài trợ.
- AC2: Gửi thành công sẽ tự tạo một mã hợp đồng ở trạng thái Chờ xác nhận.

- 4. User Story 4 - Tác nhân Nhà tài trợ
+ Story: Là một Nhà tài trợ, tôi muốn xem logo doanh nghiệp hiển thị trên trang danh dự của CLB để quảng bá thương hiệu tới sinh viên toàn trường.
+ Tiêu chí nghiệm thu:
- AC1: Cho phép tải lên file ảnh logo định dạng PNG hoặc JPG dung lượng dưới 5MB.
- AC2: Logo xuất hiện ở trang đối tác ngay sau khi hợp đồng tài trợ được xác nhận.

- 5. User Story 5 - Tác nhân Thủ quỹ CLB
+ Story: Là một Thủ quỹ CLB, tôi muốn cập nhật trạng thái đóng quỹ thành viên hàng tháng để nắm rõ nguồn ngân sách hiện tại của CLB.
+ Tiêu chí nghiệm thu:
- AC1: Giao diện hiện danh sách thành viên có ô tích chọn Đã đóng hoặc Chưa đóng.
- AC2: Bấm lưu thì tổng số dư quỹ tự động cộng thêm tiền và hiển thị ở phần báo cáo.
