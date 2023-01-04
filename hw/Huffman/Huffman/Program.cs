using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace huffman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int c = 33;
            string sr = System.Text.UTF8Encoding.UTF8.GetString(new byte[] {(byte)c});*/
            Console.WriteLine("Veuillez entrer le texte à compresser");
            string str = Console.ReadLine();

            HuffmanMessage msg = HuffmanEncyptor.Encrypt(str);
            Console.WriteLine("En format actuel " + str + " est constituée de " + str.Length + " chars, ce qui represente " + str.Length * 16 + " bits.");
            Console.WriteLine("En format huffman le message pèse " + msg.Size + " bits.\n");
            Console.WriteLine("En format huffman le message CONVERTIT EN CHAR pèse " + msg.Message + " bits.\n");

            Console.WriteLine("Format compressé: ");
            Console.WriteLine(msg);
            Console.WriteLine("Decompresse");
            Console.WriteLine(msg.Decompress());





            //string strz = JsonSerializer.Serialize<HuffmanMessage>(msg);
            string strz = JsonSerializer.Serialize<HuffmanMessage>(msg);
            Console.WriteLine("serialisee le message pèse " + strz.Length * 16 + " bits.");
            //Console.WriteLine("ND�Sc����_�\r\n<�\u007f���Xi-S���f���\u0006I�J��MP/î�}O����v��\u0013�[�c��}<�\u001c�Zv;���J��-�\u007fK��\u0015W\u000f�\u001e��^���߮�}/\u0014w��\u00163�bf�/�5Gyʡ\u000fW�7����:���+�^�-A��S��[���*o��߳���\r\n/;\u007f�_j]\u001d���DT=�����'\fRA��\u0016��auk���ĜKz�t\u0013�[�-A�\u0013Q�\u0002g/ѻ���O�0ծ�}O����X�\u0005K���b&�8\a�[.�\u001ce\u0010�-R�ǋ\r\nF\r\nW=���\u0015\u001d\u007fPO�{o\v�]�+v߃���[xTvC���gK�H��\u007fK�M}s�A���\tW_��y{pb����T������<_�<\v\u0006��{I�U���<��y\u001e�/�>a�>�\u0015z�\t��=�j�M��0����f��W/�K-���\u0014VD\t��\u0013����\u001b\u007fWϊ(a�u�\u0015}O�nV\u0016F>���\ay����*a�Y���s��{\u001bdw�\u0004��La�*��f�4Ǻ/Xlu�\u001e-\u0012��n��<ϱ�\v\u0016}$�\\W;\u0019�n����ϊ(a\u0019v����\\q�b��ǫ�ْ��v2��Z\v;\u007f��z-��#1�ND�{[�\f�����\u001c�)�>\\A�\"�}��`\u001c�[����D$;5V��oE�\u0010<;�����\u000f\v��{\v��n���{�*��\u0016}�P��e�\t�-9�Ї+X���C���\u0005o�p��g��7�Av�:��\u0016�\u0015>^=����^˰X\u0015�yk���U/R�ǋ\r\n\u0006y��\"J\b��x��o-�\"J\b��x�9������ْ5��p݄�/{��z�Gb�e\b\u0005����7;\u007f\u001dD�o�4Պ�?�\u0017���\u0015��T��K�\u001b)\\��C-�q\u0019*Xޢ�^$�����\\$�\u0015��YY�p�ȳ`ȓ�Т�Ĝ{�\u0005�����J���e�`���fx��\u001e�\u0019=ʙ�҂�(���\v��\u00168��y�\t+-�K�\u0004�zX%̉Hvj�4S�%,�JX\v��y>�\v�ZX��ќ����c.���\u00178{-�X����\u0016����X�։���\u001e-xk��\u0015�\u0015W�n�Y���sE�[�D\u0002�\u0015�턋'{�\t+-�T��a�\u0016\u001e�ݢ��Z����{�pճ\"��-�T��>au�d����6�U/*ruy�j\u001dD�o��X��\u001e�\u0018�n���b� ����\"�<���|9�6W\u0014�%τ�F�Y�u������N�\r\n\u0016����G\u001f\u0017�=ZlV�x��vo�Q�M�nVD\t3o����\u007fK�-6���� q��>a'p��9�T#\u001f�|�\u0013\tdW0�x̝��\a���������)\r\n�\r\n�;'{�)\f���� �'{X�ND�\u0013\tdW�N��\u0017���\u001b�\u000f���>aX%̊(�<��y\u001edw��LXiI�U�\"�}��`�9��S\u001a�[(���w��Vt�A=���U�����fE��$u%�9\u0011�N��&��p�p��Q.\u0014�}��Y��Js���WO7Hܾ��璯�e7�v�Yv�\u0015�\u001f}(�\u001eT\u000f��{�_jE�\u001f^=���\t\u0017\u000f�ԕ(gea�h�]��\u0001<�>\u0012s\u000eRA��\f���F\u0019�\u0017�\u0016����{��:�7�-\u0012�M������h�-YK\u000e5�ޯn-�\u0015Q��L�q\u000e}��o\t��7��û�%z�\u001d���?.C\u0005Sߊ�?�zo'\\<���\u0015��D\u007fk�EE�.O�_�-A7���\u0005\u000f��\u001fV�{pb��Av��-<*�YY�+�ޒ��^6���\\\u0011%\u0004�N<HRW��c�6�����\u0082�\u0016Vy{;1*X����%�\u0006y������i��Y\u0011�\u001e+ݜ�?ϣ\fգ\r\nW�\f���v����\u0012k\u0019V�\u0b45U�Z�ċ>\u0012s�\u0012F\u001f\u0017�Ũ>?J�ҭ���[(����\u0012tC\u001f�`��\u0004�bT�\u001f�0���',*ruy\u0002");
            //Console.WriteLine("ND�Sc����_�\r\n<�\u007f���Xi-S���f���\u0006I�J��MP/î�}O����v��\u0013�[�c��}<�\u001c�Zv;���J��-�\u007fK��\u0015W\u000f�\u001e��^���߮�}/\u0014w��\u00163�bf�/�5Gyʡ\u000fW�7����:���+�^�-A��S��[���*o��߳���\r\n/;\u007f�_j]\u001d���DT=�����'\fRA��\u0016��auk���ĜKz�t\u0013�[�-A�\u0013Q�\u0002g/ѻ���O�0ծ�}O����X�\u0005K���b&�8\a�[.�\u001ce\u0010�-R�ǋ\r\nF\r\nW=���\u0015\u001d\u007fPO�{o\v�]�+v߃���[xTvC���gK�H��\u007fK�M}s�A���\tW_��y{pb����T������<_�<\v\u0006��{I�U���<��y\u001e�/�>a�>�\u0015z�\t��=�j�M��0����f��W/�K-���\u0014VD\t��\u0013����\u001b\u007fWϊ(a�u�\u0015}O�nV\u0016F>���\ay����*a�Y���s��{\u001bdw�\u0004��La�*��f�4Ǻ/Xlu�\u001e-\u0012��n��<ϱ�\v\u0016}$�\\W;\u0019�n����ϊ(a\u0019v����\\q�b��ǫ�ْ��v2��Z\v;\u007f��z-��#1�ND�{[�\f�����\u001c�)�>\\A�\"�}��`\u001c�[����D$;5V��oE�\u0010<;�����\u000f\v��{\v��n���{�*��\u0016}�P��e�\t�-9�Ї+X���C���\u0005o�p��g��7�Av�:��\u0016�\u0015>^=����^˰X\u0015�yk���U/R�ǋ\r\n\u0006y��\"J\b��x��o-�\"J\b��x�9������ْ5��p݄�/{��z�Gb�e\b\u0005����7;\u007f\u001dD�o�4Պ�?�\u0017���\u0015��T��K�\u001b)\\��C-�q\u0019*Xޢ�^$�����\\$�\u0015��YY�p�ȳ`ȓ�Т�Ĝ{�\u0005�����J���e�`���fx��\u001e�\u0019=ʙ�҂�(���\v��\u00168��y�\t+-�K�\u0004�zX%̉Hvj�4S�%,�JX\v��y>�\v�ZX��ќ����c.���\u00178{-�X����\u0016����X�։���\u001e-xk��\u0015�\u0015W�n�Y���sE�[�D\u0002�\u0015�턋'{�\t+-�T��a�\u0016\u001e�ݢ��Z����{�pճ\"��-�T��>au�d����6�U/*ruy�j\u001dD�o��X��\u001e�\u0018�n���b� ����\"�<���|9�6W\u0014�%τ�F�Y�u������N�\r\n\u0016����G\u001f\u0017�=ZlV�x��vo�Q�M�nVD\t3o����\u007fK�-6���� q��>a'p��9�T#\u001f�|�\u0013\tdW0�x̝��\a���������)\r\n�\r\n�;'{�)\f���� �'{X�ND�\u0013\tdW�N��\u0017���\u001b�\u000f���>aX%̊(�<��y\u001edw��LXiI�U�\"�}��`�9��S\u001a�[(���w��Vt�A=���U�����fE��$u%�9\u0011�N��&��p�p��Q.\u0014�}��Y��Js���WO7Hܾ��璯�e7�v�Yv�\u0015�\u001f}(�\u001eT\u000f��{�_jE�\u001f^=���\t\u0017\u000f�ԕ(gea�h�]��\u0001<�>\u0012s\u000eRA��\f���F\u0019�\u0017�\u0016����{��:�7�-\u0012�M������h�-YK\u000e5�ޯn-�\u0015Q��L�q\u000e}��o\t��7��û�%z�\u001d���?.C\u0005Sߊ�?�zo'\\<���\u0015��D\u007fk�EE�.O�_�-A7���\u0005\u000f��\u001fV�{pb��Av��-<*�YY�+�ޒ��^6���\\\u0011%\u0004�N<HRW��c�6�����\u0082�\u0016Vy{;1*X����%�\u0006y������i��Y\u0011�\u001e+ݜ�?ϣ\fգ\r\nW�\f���v����\u0012k\u0019V�\u0b45U�Z�ċ>\u0012s�\u0012F\u001f\u0017�Ũ>?J�ҭ���[(����\u0012tC\u001f�`��\u0004�bT�\u001f�0���',*ruy\u0002".Length);
            File.WriteAllText("output.txt", strz);
            /*Console.WriteLine(strz);
            HuffmanMessage msg2 = JsonSerializer.Deserialize<HuffmanMessage>(strz);
            Console.WriteLine(strz);*/
            /*Dictionary<bool[], string> dict = new Dictionary<bool[], string>();
            dict.Add(new bool[] { false, true, false }, "str");
            Console.WriteLine(dict[new bool[] {false, true, false}]);*/
        }
    }
}