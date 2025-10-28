# 🏋️‍♂️ Salalah Fitness Club — Member and Class Management

## 📘 Repository Description  
This project is a **console-based C# system** designed for **Salalah Fitness Club** to manage members, trainers, and fitness classes.  
It focuses on applying **Object-Oriented Programming (OOP)** principles such as **inheritance, encapsulation, and class relationships** to create a simple but structured management solution.  

---

## 🎯 Objective  
Design and implement a **simple console-based system** that helps **Salalah Fitness Club** manage:  
- Members  
- Trainers  
- Fitness classes  

The system demonstrates **OOP design only** — no advanced database or UI components are used.  

---

## 📖 Story & Requirements  
The fitness club needs a basic system where they can:

- Add members and trainers  
- Create fitness classes  
- Assign trainers to classes  
- Register members into classes  
- View class details (trainer + enrolled members)  
- Calculate membership cost depending on type (Monthly, Quarterly, Yearly)

---

## 🧩 OOP Breakdown  

### 🧑‍🤝‍🧑 Person *(Base Class)*  
**Fields:**  
- `Id`  
- `FullName`  
- `Age`  

**Methods:**  
- `DisplayInfo()` → Displays basic person details.  

---

### 💪 Member *(Inherits from Person)*  
**Extra Fields:**  
- `MembershipType` *(enum: Monthly, Quarterly, Yearly)*  

**Properties:**  
- `List<FitnessClass> RegisteredClasses`  

**Methods:**  
- `RegisterToClass(FitnessClass fitnessClass)` → Registers a member to a fitness class.  
- `ShowRegisteredClasses()` → Displays all classes the member is enrolled in.  

---

### 🧘 Trainer *(Inherits from Person)*  
**Field:**  
- `Specialization` *(e.g., “Cardio”, “Yoga”)*  

**Properties:**  
- `List<FitnessClass> AssignedClasses`  

**Methods:**  
- `AssignToClass(FitnessClass fitnessClass)` → Assigns the trainer to a class.  
- `ShowAssignedClasses()` → Displays all classes assigned to the trainer.  

---

### 🏃 FitnessClass  
**Fields:**  
- `ClassName`  
- `Schedule`  
- `Trainer`  
- `List<Member> EnrolledMembers`  

**Methods:**  
- `AddMember(Member member)` → Adds a member to the class.  
- `ShowClassDetails()` → Displays trainer name and all enrolled members.  

---

### 🏢 FitnessCenter  
**Holds Lists:**  
- `List<Member> Members`  
- `List<Trainer> Trainers`  
- `List<FitnessClass> Classes`  

**Methods:**  
- `AddMember()`  
- `AddTrainer()`  
- `CreateClass()`  
- `AssignTrainerToClass()`  
- `RegisterMemberToClass()`  
- `ShowAllClasses()`  

---

## 🧠 Concepts Covered  
- **Classes & Objects**  
- **Inheritance (Base & Derived Classes)**  
- **Encapsulation (Private Fields, Public Methods)**  
- **Object Composition (Trainer ↔ Class ↔ Member relationships)**  
- **Enums (Membership Types)**  
- **Lists and Collection Management**  

---

## 🧑‍💻 Author
**Fahad Mohammed BaOmar**  
📍 Salalah, Oman  
📧 [fahadbao2002@gmail.com](mailto:fahadbao2002@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/fahad-baomar-b1a285213)##
---
