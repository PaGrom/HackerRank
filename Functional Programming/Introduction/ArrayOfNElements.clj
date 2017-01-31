;; https://www.hackerrank.com/challenges/fp-array-of-n-elements

(
    let [lines (line-seq (java.io.BufferedReader. *in*))] (
        println(
               (fn[n] (repeat n n))
               (Integer. (first lines))
        )
    )
)
