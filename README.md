# AOI Equipment Control System Demo

这是一个使用 C# WinForms 建立的自动光学检测设备控制系统 Demo。

项目目标是模拟工业自动化设备软件的基础结构，作为光学检测 / 自动化设备软件工程师作品集使用。后续会逐步加入 HMI 操作介面、机台状态控制、Recipe 参数管理、Log 记录、CSV 检测结果输出、TCP/IP 设备通讯模拟器，以及 AOI 影像检测流程。

## 目前开发状态

目前完成 Phase 1：项目初始化。

已完成内容：

- 建立基础资料夹结构
- 建立机台状态模型
- 建立 Recipe 参数模型
- 建立检测结果模型
- 建立简单 LoggerService
- 新增 sample `Config/recipe.json`

尚未实作：

- TCP/IP 通讯
- OpenCV / OpenCvSharp 影像检测
- HMI 操作按钮与画面显示
- CSV 检测结果输出

## 项目结构

```text
AOIEquipmentControlSystem/
├── Forms/
├── Models/
│   ├── MachineState.cs
│   ├── Recipe.cs
│   └── InspectionResult.cs
├── Services/
│   └── LoggerService.cs
├── Config/
│   └── recipe.json
├── Logs/
├── Images/
└── Results/
```

## Phase 1 文件说明

- `Models/MachineState.cs`：定义机台状态，例如 Idle、Running、Alarm、Stopped。
- `Models/Recipe.cs`：保存检测参数，例如曝光时间、阈值、ROI 范围。
- `Models/InspectionResult.cs`：保存单笔检测结果资料。
- `Services/LoggerService.cs`：提供简单 Log 写入功能。
- `Config/recipe.json`：sample Recipe 参数档，后续会用于 Recipe 读取功能。

## 如何验证

在 repository 根目录执行：

```powershell
dotnet build .\AOIEquipmentControlSystem\AOIEquipmentControlSystem.csproj
```

预期结果：项目可以成功 build，且没有错误。
