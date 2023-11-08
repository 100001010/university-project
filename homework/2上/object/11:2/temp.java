package weka;
import weka.core.Instances;
import weka.classifiers.trees.J48;
import weka.gui.treevisualizer.*;
import weka.core.Instance;
import weka.core.Attribute;
import weka.core.converters.ArffLoader;
import weka.core.converters.CSVLoader;
import weka.core.converters.XRFFLoader;
import weka.core.converters.XRFFSaver;
import weka.core.converters.ConverterUtils.DataSource;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.DefaultTableCellRenderer;
import java.awt.*;
import java.io.File;
import java.util.Random;
import weka.classifiers.evaluation.Evaluation;
import weka.core.SerializationHelper;
import weka.classifiers.bayes.NaiveBayes;




class CenteredTableCellRenderer extends DefaultTableCellRenderer {
    @Override
    public Component getTableCellRendererComponent(JTable table, Object value, boolean isSelected, boolean hasFocus, int row, int column) {
        Component component = super.getTableCellRendererComponent(table, value, isSelected, hasFocus, row, column);
        
        // 設定水平對齊方式為置中
        setHorizontalAlignment(SwingConstants.CENTER);
        
        return component;
    }
}

public class work {

	public static void main(String[] args)  throws Exception{
		System.out.println("使用 DataSource 類的 read 方法來加載 ARFF 文件");
		Instances datal =DataSource.read("C:\\Program Files\\Weka-3-8-6\\data\\weather.numeric.arff");
		System.out.println("資料集內容:");
		System.out.println(datal);
		if (datal.classIndex() == -1)
			datal.setClassIndex(datal.numAttributes() -1);
		System.out.println(datal.classIndex());
		for(int j = 0; j < datal.numAttributes(); j++){

			Attribute att = datal.attribute(j);

			System.out.print(att.name()+"\t");

		}

		System.out.println();
		for(int j = 0; j < datal.numAttributes(); j++)

		{

		Attribute att = datal.attribute(j);

		System.out.print(att.typeToString(att.type())+"\t");

		}

		System.out.println();
		for(int i = 0; i < datal.numInstances(); i++){

			Instance row = datal.instance(i);

			for(int j = 0; j < datal.numAttributes(); j++)

				System.out.print(row.value(j)+"\t");

			System.out.println();

		}
		
		JFrame frame = new JFrame("Show Data");

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frame.setLayout(new GridLayout(2,2));
		
		

		DefaultTableModel tableModel = new DefaultTableModel();
		JTable table = new JTable(tableModel);
		JScrollPane scrollPane = new JScrollPane(table);
		frame.add(scrollPane);
		table.setDefaultRenderer(Object.class, new CenteredTableCellRenderer());
		
		DefaultTableModel tableMode2 = new DefaultTableModel();
		JTable table2 = new JTable(tableMode2);
		JScrollPane scrollPane2 = new JScrollPane(table2);
		frame.add(scrollPane2);
		table2.setDefaultRenderer(Object.class, new CenteredTableCellRenderer());
		
		DefaultTableModel tableMode3 = new DefaultTableModel();
		JTable table3 = new JTable(tableMode3);
		JScrollPane scrollPane3 = new JScrollPane(table3);
		frame.add(scrollPane3);
		table3.setDefaultRenderer(Object.class, new CenteredTableCellRenderer());
		
		DefaultTableModel tableMode4 = new DefaultTableModel();
		JTable table4 = new JTable(tableMode4);
		JScrollPane scrollPane4 = new JScrollPane(table4);
		frame.add(scrollPane4);
		table4.setDefaultRenderer(Object.class, new CenteredTableCellRenderer());
		
		

		for(int j = 0; j < datal.numAttributes(); j++)

		{

			Attribute att = datal.attribute(j);

			tableModel.addColumn(att.name()+" / "+att.typeToString(att.type()));

		}

		for(int i = 0; i < datal.numInstances(); i++)

		{

			Instance row = datal.instance(i);

			String [] newRow = new String[datal.numAttributes()];

			for(int j = 0; j < datal.numAttributes(); j++)

					newRow[j] = String.valueOf(row.value(j));

			tableModel.addRow(newRow);

			System.out.println();

		}

		frame.setVisible(true);
		
		
		tableMode2.addColumn("欄位");
		for(int j = 0; j < datal.numAttributes(); j++)

		{

			Attribute att = datal.attribute(j);

			tableMode2.addColumn(att.name()+" / "+att.typeToString(att.type()));

		}
		String [] newRow = new String[datal.numAttributes()+1];
		newRow[0] = "data type";

		for(int j = 0; j < datal.numAttributes(); j++)
			if(datal.attribute(j).type()==0)
				newRow[j+1] = "N";
			else
				newRow[j+1] = "C";
		tableMode2.addRow(newRow);
		
		newRow[0] = "不同值的個數";
		for(int j = 0; j < datal.numAttributes(); j++)
				newRow[j+1] = String.valueOf(datal.attributeStats(j).distinctCount);
		tableMode2.addRow(newRow);

		newRow[0] = "空值的個數";
		for(int j = 0; j < datal.numAttributes(); j++)
				newRow[j+1] = String.valueOf(datal.attributeStats(j).missingCount);
		tableMode2.addRow(newRow);
		
		newRow[0] = "空值的比例";
		for(int j = 0; j < datal.numAttributes(); j++)
				newRow[j+1] = String.valueOf(datal.attributeStats(j).missingCount/ datal.numInstances());
		tableMode2.addRow(newRow);
		
		newRow[0] = "有值的個數";
		for(int j = 0; j < datal.numAttributes(); j++)
				newRow[j+1] = String.valueOf( datal.numInstances()-datal.attributeStats(j).missingCount);
		tableMode2.addRow(newRow);
		
		newRow[0] = "有值的比例";
		for(int j = 0; j < datal.numAttributes(); j++)
				newRow[j+1] = String.valueOf( (datal.numInstances()-datal.attributeStats(j).missingCount)/datal.numInstances());
		tableMode2.addRow(newRow);
		
		
		
		tableMode3.addColumn("Numeric");
		tableMode3.addColumn("Min");
		tableMode3.addColumn("Max");
		tableMode3.addColumn("Mean");
		tableMode3.addColumn("StDev");
		tableMode3.addColumn("M-3");
		tableMode3.addColumn("M+3");
		newRow = new String[7];
		for(int i=0;i<datal.numAttributes();i++) {
			if(datal.attribute(i).type()==0) {
				newRow[0] = datal.attribute(i).name();
				newRow[1] =String.format("%.3f",datal.attributeStats(i).numericStats.min); //取得第i个属性的最小值
				newRow[2] =String.format("%.3f",datal.attributeStats(i).numericStats.max); //取得第i个属性的最大值
				newRow[3] =String.format("%.3f",datal.attributeStats(i).numericStats.mean );//取得第i个属性的平均值
				newRow[4] =String.format("%.3f",datal.attributeStats(i).numericStats.stdDev );//取得第i个属性的标准偏差
				newRow[5] =String.format("%.3f",datal.attributeStats(i).numericStats.mean-3*datal.attributeStats(i).numericStats.stdDev );//取得第i个属性的标准偏差
				newRow[6] =String.format("%.3f",datal.attributeStats(i).numericStats.mean+3*datal.attributeStats(i).numericStats.stdDev);//取得第i个属性的标准偏差

				
				tableMode3.addRow(newRow);
			}
			
		}
		int maxNum=0;
		for(int j = 0; j < datal.numAttributes(); j++){

			Attribute att = datal.attribute(j);

			if(att.type() == 1){

				System.out.print(att.name()+"\t");

				//取得第i个属性的各個類別值的計數

				int [] count = datal.attributeStats(j).nominalCounts;
				if(count.length>maxNum)
					maxNum=count.length;
				for(int k = 0; k < count.length; k++)

					//取得第i个属性的第j個類別值的名稱

					System.out.print(datal.attribute(j).value(k) + " = " + count[k] + "\t");

				System.out.println();

			}
			
		}
		tableMode4.addColumn("Categorical");
		for(int i=1;i<=maxNum;i++)
			tableMode4.addColumn(String.valueOf(i));
		
		for(int j = 0; j < datal.numAttributes(); j++){
			
			
			Attribute att = datal.attribute(j);

			if(att.type() == 1){


				//取得第i个属性的各個類別值的計數

				int [] count = datal.attributeStats(j).nominalCounts;
				newRow = new String[maxNum+1];
				newRow[0]= att.name();
				for(int k = 0; k < count.length; k++) {
					newRow[k+1]=datal.attribute(j).value(k);
				}
				tableMode4.addRow(newRow);
				
				newRow = new String[maxNum+1];	
				newRow[0]= "number";
				double total=0;
				for(int k = 0; k < count.length; k++) {
					total+=count[k];
					newRow[k+1]=String.valueOf(count[k]);
				}
				tableMode4.addRow(newRow);
				
				newRow = new String[maxNum+1];
				newRow[0]= "%";
				for(int k = 0; k < count.length; k++) {
					newRow[k+1]=String.format("%.2f",count[k]/total);
				}
				
				tableMode4.addRow(newRow);
				
				newRow = new String[maxNum+1];
				tableMode4.addRow(newRow);

			}
			
		}
		
		frame.setVisible(true);
		J48 tree = new J48();
		String options = "-C 0.25 -M 2";
		String [] option = options.split(" ");
		tree.setOptions(option);
		tree.buildClassifier(datal);
		TreeVisualizer tv = new TreeVisualizer(null, tree.graph(), new PlaceNode2());
		JFrame jf = new JFrame("Tree Visualization for J48 Classifier");
		jf.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		jf.setSize(800, 600);
		jf.getContentPane().setLayout(new BorderLayout());
		jf.getContentPane().add(tv, BorderLayout.CENTER);
		jf.setVisible(true);
		tv.fitToScreen();
		
		Evaluation eval = new Evaluation(datal);
		eval.crossValidateModel(tree, datal, 10, new Random(1));
		System.out.println(eval.toSummaryString("=== Summary ===\n", false));
		System.out.println(eval.toClassDetailsString());
		System.out.println(eval.toMatrixString());

		System.out.printf("%4s %-10s %-10s Error Distri.%n","ID","Actual","Predict");
		for(int i = 0; i < datal.numInstances(); i++) {
			double pred = tree.classifyInstance(datal.instance(i)); //预测结果
			double [] dist = tree.distributionForInstance(datal.instance(i)); //概率分布
			System.out.printf("%4d ",(i+1));
			System.out.printf("%-10s ",datal.instance(i).toString(datal.classIndex()));
			System.out.printf("%-10s ",datal.classAttribute().value((int)pred));
			if(pred != datal.instance(i).classValue())
				System.out.print("  +   ");
			else
				System.out.print("      ");
			for(int j = 0; j < dist.length; j++)
				System.out.printf("%6.2f  ",dist[j]);
			System.out.println();
			
			
			
		}
		SerializationHelper.write("C:\\Users\\eric9\\Desktop\\J48.model",tree);	
		tree = (J48) SerializationHelper.read("C:\\Users\\eric9\\Desktop\\J48.model");
		System.out.println(tree.toString());
		
		NaiveBayes nb = new NaiveBayes();
		nb.buildClassifier(datal);
		System.out.println(nb.toString()); //显示结果//10折交叉驗證
		eval.crossValidateModel(nb, datal, 10, new Random(1));
		System.out.println(eval.toSummaryString("=== Summary ===\n", false));
	

	}
}