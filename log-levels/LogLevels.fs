module LogLevels

let message (logLine: string) =
    logLine.Substring(logLine.IndexOf(":") + 2).Trim()

let logLevel (logLine: string) =
    logLine
        .Substring(1, logLine.IndexOf(":") - 2)
        .ToLower()

let reformat logLine =
    $"{message logLine} ({logLevel logLine})"
