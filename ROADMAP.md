# AOI Equipment Control System Demo Roadmap

这个 roadmap 用来整理项目开发方向，方便查看目前进度和下一步计划。

## 项目目标

建立一个 C# WinForms 自动光学检测设备控制系统 Demo，模拟工业自动化设备软件的常见功能。

项目重点：

- HMI 操作画面
- 机台状态控制
- Recipe 参数管理
- TCP/IP 设备通讯模拟
- AOI 影像检测流程
- Alarm 与 Log 管理
- CSV 检测结果输出

## 当前状态

目前完成到 Phase 4。

已具备：

- 基础 WinForms 项目
- 标准资料夹结构
- 基础 Models
- LoggerService
- MachineService 基础状态控制
- RecipeService
- JSON Recipe 读取、显示、编辑与保存
- MachineService 状态转换规则强化
- Current Alarm Message 显示
- 流程步骤 log
- MainForm 基础 HMI

尚未开始：

- TCP/IP Device Simulator
- OpenCvSharp AOI inspection
- CSV result export
- 完整作品集文件整理

## Phase 1 - 项目初始化

状态：已完成

目标：建立项目基础结构，让后续功能可以分层开发。

完成内容：

- 建立 C# WinForms 项目
- 建立资料夹：`Forms`、`Models`、`Services`、`Config`、`Logs`、`Images`、`Results`
- 新增 `MachineState` enum
- 新增 `Recipe` model
- 新增 `InspectionResult` model
- 新增 `LoggerService`
- 新增 sample `Config/recipe.json`
- 更新 README

## Phase 2 - 基础 HMI 与 MachineService

状态：已完成

目标：建立基础 HMI 画面，并让按钮可以模拟基本机台操作。

完成内容：

- Initialize button
- Start Auto button
- Stop button
- Reset button
- Clear Alarm button
- Machine Status label
- Device Connection Status label
- Recipe parameter display area
- Log display area
- Result DataGridView
- 新增 `MachineService`
- 实作基础状态转换：`Idle`、`Initializing`、`Ready`、`Running`、`Inspecting`、`Completed`、`Alarm`、`Stopped`

## Phase 3 - Recipe 管理

状态：已完成

目标：让系统从 JSON 读取 recipe，显示在 HMI 上，并允许使用者编辑保存。

完成内容：

- 新增 `RecipeService`
- 从 `Config/recipe.json` 读取 recipe
- 将 recipe 参数显示到 MainForm
- 在 MainForm 编辑 recipe 参数
- 保存 recipe 回 `Config/recipe.json`
- 保存成功或失败都会写入 Log

注意：本阶段不做 AOI 检测，只处理 recipe 资料管理。

## Phase 4 - State Machine 强化

状态：已完成

目标：让机台状态控制更接近真实设备软件。

完成内容：

- 整理 MachineService 状态转换规则
- 加入状态转换检查
- 加入更清楚的 alarm message
- 加入流程步骤 log
- 让 UI 更清楚显示当前状态

## Phase 5 - TCP/IP Device Simulator

状态：下一阶段

目标：模拟上位机与设备之间的 TCP/IP 通讯。

建议拆分：

- Phase 5A：新增 DeviceSimulatorServer，可以接收 command 并回传基础 response。
- Phase 5B：新增 TcpClientService，让 HMI 可以 connect / disconnect simulator。
- Phase 5C：让自动流程开始使用 TCP command 模拟设备动作。
- Phase 5D：加入 timeout、retry、error code 和 alarm handling。

计划内容：

- 新增 TCP client service
- 新增 device simulator server
- 支持基础 command：
  - `INIT`
  - `HOME`
  - `MOVE`
  - `LIGHT ON`
  - `CAPTURE`
  - `RESET`
- 支持基础 response：
  - `OK`
  - `DONE`
  - `ERROR`
- 加入 timeout handling
- 加入 retry handling
- 在 UI 显示 communication log

## Phase 6 - AOI Image Inspection

状态：规划中

目标：使用 OpenCvSharp 完成基础 AOI 影像检测流程。

计划内容：

- 安装 OpenCvSharp
- 新增 `ImageProcessingService`
- 读取 sample image
- ROI crop
- grayscale
- threshold
- find contours
- measure area
- 判断 OK / NG
- 保存 processed image

## Phase 7 - 检测结果输出

状态：规划中

目标：将检测结果输出成可追溯的资料。

计划内容：

- 新增 `ResultExportService`
- 输出 inspection result 到 CSV
- 保存检测时间、产品名称、面积、阈值、OK/NG 结果
- 在 DataGridView 显示真实检测结果

## Phase 8 - 作品集整理

状态：规划中

目标：整理项目展示资料，让作品集更容易被理解。

计划内容：

- 更新 README
- 加入 screenshots
- 加入 system flow diagram
- 加入 state machine 说明
- 加入 communication protocol 说明
- 加入操作说明和验证步骤

## 暂不纳入范围

这些内容目前不做，避免项目过度复杂：

- SQL Server
- WPF
- Deep Learning
- 真实相机 SDK
- 真实 PLC / motion controller
- 真实公司资料或真实机台参数
