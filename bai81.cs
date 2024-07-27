
Lệnh Thread.Sleep(100) và Task.Delay(100) đều dùng để delay thời gian trong C#, nhưng chúng có một số khác biệt như sau:

Nguồn gốc:
Thread.Sleep(100) là một phương thức của lớp Thread trong namespace System.Threading.
Task.Delay(100) là một phương thức của lớp Task trong namespace System.Threading.Tasks.
Cách hoạt động:
Thread.Sleep(100) làm cho luồng(thread) hiện tại "ngủ" trong 100 milliseconds, không thực hiện bất kỳ công việc nào trong khoảng thời gian này.
Task.Delay(100) tạo ra một Task mới, lên lịch để thực hiện sau 100 milliseconds, nhưng không làm "ngủ" luồng hiện tại.Luồng hiện tại có thể tiếp tục thực hiện các công việc khác trong khi chờ Task này hoàn thành.
Ảnh hưởng đến hiệu suất:
Thread.Sleep(100) làm "ngủ" luồng hiện tại, làm giảm hiệu suất của ứng dụng, vì không có công việc nào được thực hiện trong khoảng thời gian này.
Task.Delay(100) không làm "ngủ" luồng hiện tại, thay vào đó tạo ra một Task mới, để luồng hiện tại có thể tiếp tục thực hiện các công việc khác.Điều này giúp cải thiện hiệu suất của ứng dụng.
Sử dụng trong các ứng dụng asynchronous:
Thread.Sleep(100) không phù hợp với các ứng dụng asynchronous, vì nó làm "ngủ" luồng hiện tại, không cho phép các tác vụ khác được thực hiện.
Task.Delay(100) phù hợp hơn với các ứng dụng asynchronous, vì nó không làm "ngủ" luồng hiện tại, mà chỉ lên lịch cho một Task được thực hiện sau 100 milliseconds.
