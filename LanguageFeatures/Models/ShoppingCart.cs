using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class ShoppingCart: IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        // IEnumerable<T>インタフェースの実装
        public IEnumerator<Product> GetEnumerator() {
            return Products.GetEnumerator();
        }

        // IEnumerableインタフェースの実装．IE<T>との区別のため，インタフェース名をつける．
        // インタフェースを介してのみ呼び出せる．
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // IE<T>を返すGetEnumeratorを呼び出す．
        }
    }
}