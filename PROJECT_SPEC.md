# AOI Equipment Control System Demo - 项目规格书

## 1. 项目简介

这个项目模拟自动光学检测设备的软件系统。

系统包含：

- HMI 操作画面
- 机台状态管理
- 自动检测流程
- 设备通讯模拟
- 影像检测流程
- Alarm 和 Log 管理
- CSV 检测结果输出

## 2. 目标使用者

目标使用者是操作 AOI 机台的工程师。

使用者应该可以：

- 初始化机台
- 启动自动检测
- 停止机台
- 重置异常
- 读取 Recipe 参数
- 编辑并保存 Recipe 参数
- 查看机台状态
- 查看 alarm message
- 查看检测图片
- 查看 OK / NG 检测结果
- 输出检测结果

## 3. 主画面需求

WinForms 主画面需要包含：

- Initialize 按钮
- Start Auto 按钮
- Stop 按钮
- Reset 按钮
- Clear Alarm 按钮
- Save Recipe 按钮
- Machine Status Label
- Device Connection Status Label
- Current Alarm Message 显示
- Recipe Name 显示
- 参数显示与编辑区域
- Original Image 显示区域
- Processed Image 显示区域
- Inspection Result 显示区域
- Log 显示区域
- Result Table

## 4. 机台状态需求

系统使用以下状态：

- Idle
- Initializing
- Ready
- Running
- Inspecting
- Completed
- Alarm
- Stopped

## 5. Recipe 需求

Recipe 使用 JSON 格式储存。

Example fields：

- ProductName
- ExposureTime
- Threshold
- MinArea
- RoiX
- RoiY
- RoiWidth
- RoiHeight
- SavePath
- MaxRetryCount

系统需要支持：

- 从 JSON 读取 Recipe
- 在 HMI 显示 Recipe
- 在 HMI 编辑 Recipe
- 保存 Recipe 回 JSON
- 保存成功或失败时写入 Log

## 6. 通讯需求

系统需要模拟 TCP/IP 与外部设备通讯。

Example commands：

- INIT
- HOME
- MOVE X 100
- LIGHT ON
- CAPTURE
- INSPECT
- LIGHT OFF
- RESET

Example responses：

- OK
- DONE
- IMAGE_READY
- ERROR: LIMIT_SENSOR_ALARM
- ERROR: CAMERA_CAPTURE_FAILED

系统需要支持：

- Timeout handling
- Retry handling
- Error code handling
- Alarm display
- Communication log

## 7. AOI 影像检测需求

使用 OpenCvSharp 实作基础影像检测流程。

Basic flow：

```text
Original Image
-> ROI Crop
-> Grayscale
-> Blur
-> Threshold
-> Find Contours
-> Measure Area
-> OK / NG Judgement
-> Save Processed Image
-> Export Result
```

## 8. 输出需求

系统应该产生：

- Machine log file
- CSV inspection result
- Processed inspection image

CSV format：

```text
Time,ImageName,ProductName,Area,Threshold,Result,ImagePath
```

## 9. 未来改善方向

- 整合真实工业相机 SDK
- 加入 Modbus TCP / PLC 通讯
- 加入 SQL Server 资料储存
- 开发 WPF UI 版本
- 加入 AI defect detection
