CREATE TABLE WorkoutPlan (
    PlanId INT PRIMARY KEY IDENTITY(1,1),
    MemberId INT NOT NULL,
    TrainerId INT NOT NULL,
    Duration NVARCHAR(50),
    AssignedDate DATE,

    FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
    FOREIGN KEY (TrainerId) REFERENCES Trainer(TrainerId)
);
CREATE TABLE Payment (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    MemberId INT NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATE NOT NULL,
    PaymentMethod NVARCHAR(50),

    FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
);
CREATE TABLE Attendance (
    AttendanceId INT PRIMARY KEY IDENTITY(1,1),
    MemberId INT NOT NULL,
    TrainerId INT NOT NULL,
    Date DATE NOT NULL,
    Status NVARCHAR(10),

    FOREIGN KEY (MemberId) REFERENCES Member(MemberId),
    FOREIGN KEY (TrainerId) REFERENCES Trainer(TrainerId)
);
