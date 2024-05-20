insert into TableReservation(CustomerName, Date, Time,Pax) values 
('youssef', '2024-02-15', '12:30','5'),
('Reehan','2024-02-16','14:00','2');

alter table TableReservation
add [Status] nvarchar(50);

INSERT INTO TableReservation(CustomerName, Date, Time, Pax, Status) VALUES
('Sophia', '2024-02-17', '18:30', '4', 'Completed'),
('Liam', '2024-02-18', '19:00', '3', 'Confirmed'),
('Emma', '2024-02-19', '12:00', '6', 'Confirmed'),
('Olivia', '2024-02-20', '20:00', '2', 'Pending'),
('Noah', '2024-02-21', '13:30', '5', 'Pending');