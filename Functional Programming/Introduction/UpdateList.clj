;; https://www.hackerrank.com/challenges/fp-update-list

(fn[lst]
    (map #(max % (- %)) lst))

(fn[lst]
    (map #(Math/abs %) lst))
