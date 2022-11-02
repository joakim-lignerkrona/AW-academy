using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladd {
    internal class SingleTest {
        static SingleTest single;
        long count = 0;

        public static SingleTest GetInstance() {
            if(single == null) {
                single = new SingleTest();
            }
            return single;
        }

        public long StartCounting() {
            return ++count;
        }
        public long CurrentCount() {
            return count;
        }

    }
}
