# Development Tasks

这个文件作为开发 checklist 使用。整体路线图请参考 [ROADMAP.md](ROADMAP.md)。

## Phase 1 - 项目初始化

- [x] 建立 C# WinForms project
- [x] 建立资料夹结构：Forms, Models, Services, Config, Logs, Images, Results
- [x] 新增 MachineState enum
- [x] 新增 Recipe model
- [x] 新增 InspectionResult model
- [x] 新增 LoggerService
- [x] 新增 sample Config/recipe.json
- [x] 新增 README 项目简介

## Phase 2 - 基础 HMI 与 MachineService

- [x] 新增 Initialize button
- [x] 新增 Start Auto button
- [x] 新增 Stop button
- [x] 新增 Reset button
- [x] 新增 Clear Alarm button
- [x] 新增 Machine Status label
- [x] 新增 Device Connection Status label
- [x] 新增 Log display area
- [x] 新增 Result DataGridView
- [x] 新增 Recipe parameter display area
- [x] 新增 MachineService
- [x] 实作 Initialize()
- [x] 实作 StartAuto()
- [x] 实作 Stop()
- [x] 实作 Reset()
- [x] 实作 ClearAlarm()

## Phase 3 - Recipe 管理

- [x] 新增 RecipeService
- [x] 从 Config/recipe.json 读取 recipe
- [x] 在 UI 显示实际 recipe
- [x] 将 recipe 修改保存回 JSON
- [x] 保存成功或失败写入 Log

## Phase 4 - State Machine 强化

- [x] 整理 MachineService 状态转换规则
- [x] 加入状态转换检查
- [x] 加入 alarm message
- [x] 加入流程步骤显示
- [x] 改善 UI 状态显示

## Phase 5 - TCP Device Simulator

- [ ] 定义 TCP command / response protocol
- [ ] 新增 TCP client service
- [ ] 新增 device simulator server
- [ ] 从 controller 发送 command 到 simulator
- [ ] 接收 OK / DONE / ERROR response
- [ ] 加入 timeout handling
- [ ] 加入 retry handling
- [ ] 在 UI 显示 communication log

## Phase 6 - AOI Image Inspection

- [ ] 安装 OpenCvSharp
- [ ] 新增 ImageProcessingService
- [ ] 读取 sample image
- [ ] 裁切 ROI
- [ ] 转成 grayscale
- [ ] 执行 threshold
- [ ] 找 contours
- [ ] 计算 area
- [ ] 判断 OK / NG
- [ ] 储存 processed image

## Phase 7 - 结果输出

- [ ] 新增 ResultExportService
- [ ] 输出 inspection result 到 CSV
- [ ] 储存 log file
- [ ] 储存 processed image path
- [ ] 在 DataGridView 显示 result

## Phase 8 - 文件整理

- [ ] 更新 README
- [ ] 加入 screenshots
- [ ] 加入 system flow diagram
- [ ] 加入 state machine 说明
- [ ] 加入 communication protocol 说明
