;; https://www.hackerrank.com/challenges/fp-update-list

(fn[lst]
    (map #(max % (- %)) lst))
