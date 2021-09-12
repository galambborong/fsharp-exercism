module LogLevels

let message (logLine: string) =
   let idx = logLine.IndexOf(":")
   logLine.Substring(idx + 2).Trim()

let logLevel(logLine: string): string = failwith "Please implement the 'logLevel' function"

let reformat(logLine: string): string = failwith "Please implement the 'reformat' function"
